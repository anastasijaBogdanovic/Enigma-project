using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    class FileWatcher
    {
        private FileSystemWatcher watcher;
        Enigma enigma = new Enigma();
        XTEA xtea = new XTEA();
        private Random rand;
        private bool watcherOn;
        private string watchedFolder;
        private string outputFolder;
        private string keyFile = @"./keys.txt";

        public FileWatcher()
        {
            watcher = new FileSystemWatcher();
            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            watcher.Changed += OnChanged;
            watcher.Filter = "*.txt";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = false;

            rand = new Random();
            watcherOn = false;
            watchedFolder = "";
            outputFolder = "";
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            string location = $"Created: {e.FullPath}";
            Console.WriteLine(location);
            if (outputFolder.Length != 0)
                this.EncryptTextFile(e.FullPath, this.outputFolder);
            else
                Console.WriteLine("You have to set the output folder");
        }

        public void TurnOnFileSystemWatcher()
        {
            if (this.watchedFolder == "" || this.outputFolder == "")
                throw new Exception("You need to specify target and destination folders before you can turn on file system watcher");
            if (!watcherOn)
            {
                watcherOn = true;
                watcher.EnableRaisingEvents = true;
            }
        }

        public void TurnOffFileSystemWatcher()
        {
            if (watcherOn)
            {
                watcherOn = false;
                watcher.EnableRaisingEvents = false;
            }
        }

        public void SetWatchedFolder(string directory)
        {
            if (!watcherOn)
                if (outputFolder.Length == 0 || outputFolder.CompareTo(directory) != 0)
                {
                    this.watchedFolder = directory;
                    watcher.Path = directory;
                }
        }

        public void SetOutputFolder(string dir)
        {
            if (!watcherOn)
            {
                if (watchedFolder.Length == 0 || watchedFolder.CompareTo(dir) != 0)
                    this.outputFolder = dir;
            }
        }

        public bool IsFileSystemWatcherOn()
        {
            return this.watcherOn;
        }

        public string GetTargetFolder()
        {
            return this.watchedFolder;
        }

        public string GetDestinationFolder()
        {
            return this.outputFolder;
        }

        public void EncryptAllFilesFromFolder(string path)
        {
            if (this.outputFolder.Length == 0)
                throw new Exception("You need to set destination folder");

            foreach (string txtFile in Directory.GetFiles(path, "*.txt"))
                this.EncryptTextFile(txtFile, this.outputFolder);
        }

        private bool EncryptTextFile(string fileName, string outputDirectory)
        {
            string outputFileName = outputDirectory + @"\" + Path.GetFileName(fileName);
            int key = GenerateKey();
            char[] text = this.ReadTextFile(fileName);
            string encryptedText = "";
            if (enigma != null)
            {
                Console.WriteLine("ENIGMA JE UPALJENA! enkripcija");
                encryptedText = enigma.startEnigma(text, key);
            }
            else
            {
                Console.WriteLine("XTEA JE UAPLJENA enkripcija");
                encryptedText = xtea.startXTEAEncrypt(new string(text), key.ToString());
            }
            this.WriteToTextFile(outputFileName, encryptedText.ToCharArray());
            this.WriteKeyToKeyFile(outputFileName, key);

            return true;
        }

        private void WriteKeyToKeyFile(string fileName, int key)
        {
            string entry = fileName + " " + key;
            using (StreamWriter sw = File.AppendText(this.keyFile))
            {
                sw.WriteLine(entry);
            }
        }

        public bool DecryptTextFile(string fileName, string folder)
        {
            if (this.watcherOn) return false;
            string outputFileName = folder + @"\" + Path.GetFileName(fileName);

            char[] encryptedText = this.ReadTextFile(fileName);
            int key = this.GetKey(fileName);
            if (key == -1)
                return false;
            string decryptedText = "";
            if (enigma != null)
            {
                Console.WriteLine("ENIGMA JE UPALJENA! dekripcija");
                decryptedText = enigma.startEnigma(encryptedText, key);
            }
            else
            {
                Console.WriteLine("XTEA JE UPALJENA! dekripcija");
                decryptedText = xtea.startXTEADecrypt(new string(encryptedText), key.ToString());
            }
            this.WriteToTextFile(outputFileName, decryptedText.ToCharArray());

            return true;
        }

        public void ChooseEncryptionAlgorithm(int x)
        {
            if (x == 1)
                xtea = null;
            else enigma = null;
        }

        private int GenerateKey()
        {
            return rand.Next(10000);
        }

        public int GetKey(string fileName)
        {
            int key = -1;
            using (StreamReader sr = File.OpenText(this.keyFile))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    if (str.StartsWith(fileName))
                    {
                        int index = fileName.Length + 1;
                        key = int.Parse(str.Substring(index));
                        return key;
                    }
                }
            }
            return key;
        }

        private char[] ReadTextFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadToEnd().ToCharArray();
            }
        }

        private void WriteToTextFile(string path, char[] content)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Create);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(content);
                }
            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }
        }
    }
}
