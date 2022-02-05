using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Enigma
{
    public partial class Form1 : Form
    {
        private FileWatcher fileWatch;
        public Form1()
        {
            InitializeComponent();
            fileWatch = new FileWatcher();
            AlgorithmIsChosen(false);
        }

        private void ChangeValuseOnAllButtons(bool newValue)
        {
            this.target_folder_btn.Enabled = newValue;
            this.destination_folder_btn.Enabled = newValue;
            this.encrypt_btn.Enabled = newValue;
            this.decrypt_btn.Enabled = newValue;
            this.enigma_btn.Enabled = newValue;
            this.XTEA_btn.Enabled = newValue;
        }

        public void AlgorithmIsChosen(bool newValue)
        {
            this.target_folder_btn.Enabled = newValue;
            this.destination_folder_btn.Enabled = newValue;
            this.encrypt_btn.Enabled = newValue;
            this.decrypt_btn.Enabled = newValue;
        }

        private void SelectFolder(TextBox folder)
        {
            DialogResult result = this.folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)

                folder.Text = folderBrowserDialog.SelectedPath;
        }

        private void file_system_watcher_btn_Click(object sender, EventArgs e)
        {
            if (!fileWatch.IsFileSystemWatcherOn())
            {
                try
                {
                    fileWatch.TurnOnFileSystemWatcher();
                    ChangeValuseOnAllButtons(false);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                fileWatch.TurnOffFileSystemWatcher();
                ChangeValuseOnAllButtons(true);
            }
        }

        private void browse_target_folder_btn_Click(object sender, EventArgs e)
        {
            this.SelectFolder(this.target_folder_textbox);
        }

        private void target_folder_btn_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(this.target_folder_textbox.Text))
            {
                fileWatch.SetWatchedFolder(this.target_folder_textbox.Text);
                this.target_folder_textbox.Text = "";
            }
            else MessageBox.Show(
                "This folder name is invalid",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void browse_encrypt_files_btn_Click(object sender, EventArgs e)
        {
            this.SelectFolder(this.encrypt_textbox);
        }

        private void encrypt_btn_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(this.encrypt_textbox.Text))
                try
                {
                    fileWatch.EncryptAllFilesFromFolder(this.encrypt_textbox.Text);
                    MessageBox.Show(
                        "All done",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            else
                MessageBox.Show(
                    "This folder name is invalid",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            this.encrypt_textbox.Text = "";
        }

        private void browse_destination_folder_btn_Click(object sender, EventArgs e)
        {
            this.SelectFolder(this.destination_folder_textbox);
        }

        private void destination_folder_btn_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(this.destination_folder_textbox.Text))
            {
                fileWatch.SetOutputFolder(this.destination_folder_textbox.Text);
                this.destination_folder_textbox.Text = "";
            }
            else MessageBox.Show(
                "This folder name is invalid", 
                "Error", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
        }

        private void browse_decrypt_file_btn_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Filter = "Text|*.txt";
            DialogResult result = this.openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
                this.decrypt_textbox.Text = openFileDialog.FileName;
        }

        private void browse_destination_for_decrypted_file_btn_Click(object sender, EventArgs e)
        {
            this.SelectFolder(this.dest_textbox);
        }

        private void decrypt_btn_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(dest_textbox.Text) && File.Exists(decrypt_textbox.Text))
                try
                {
                    fileWatch.DecryptTextFile(decrypt_textbox.Text, dest_textbox.Text);
                    MessageBox.Show(
                        "All done", 
                        "Success", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message, 
                        "Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            else
                MessageBox.Show(
                    "This folder/file name is invalid", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);

            this.dest_textbox.Text = "";
            this.decrypt_textbox.Text = "";
        }

        private void enigma_btn_Click(object sender, EventArgs e)
        {
            fileWatch.ChooseEncryptionAlgorithm(1);
            AlgorithmIsChosen(true);
        }

        private void XTEA_btn_Click(object sender, EventArgs e)
        {
            fileWatch.ChooseEncryptionAlgorithm(2);
            AlgorithmIsChosen(true);
        }
    }
}
