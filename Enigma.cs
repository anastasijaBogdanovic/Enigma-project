using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    class Enigma
    {
        private const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private Rotor[] rotors;
        private Rotor reflector;
        
        // Moraju obe masine da imaju istu konfiguraciju rotora i reflektora da bi se tacno enkriptovalo i dekriptovalo
        private const string rotor1 = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
        private const string rotor2 = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
        private const string rotor3 = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
        private const string refA = "EJMZALYXVBWFCRQUONTSPIKHGD";
        private const string refB = "YRUHQSLDPXNGOKMIEBFZCWVJAT";
        private const string refC = "FVPJIAOYEDRZXWGCTKUQSBNMHL";

        private Dictionary<Char, Char> plugBoard;

        public Enigma()
        {
            plugBoard = new Dictionary<char, char>();
            Rotor rI = new Rotor(rotor1, 'W', "1");
            Rotor rII = new Rotor(rotor2, 'H', "2");
            Rotor rIII = new Rotor(rotor3, 'P', "3");
            rotors = new Rotor[] { rI, rII, rIII }; 
            reflector = new Rotor(refA, ' ', "0");
        }

        public char[] setRings(int key)
        {
            char[] elements = new char[3];
            int startPosition = key % 26;

            elements[0] = refA[startPosition];
            elements[1] = refB[startPosition];
            elements[2] = refC[startPosition];

            return elements;
        }

        public char[] setRotorsPosition(int key)
        {
            
            char[] elements = new char[3];
            int startPosition = key % 26;

            elements[0] = rotor1[startPosition];
            elements[1] = rotor2[startPosition];
            elements[2] = rotor3[startPosition];

            return elements;
        }

        public string setRotorOrder(int key)
        {
            string order = "";
            int num = key % 4;
            for (int i = 0; i < 3; i++)
            {
                if (num == 0)
                    num++;
                if (i != 2)
                    order += Convert.ToString(num) + "-";
                else order += Convert.ToString(num);

                num = (num + 1) % 4;
            }
            return order;
        }

        public char setRefCon(int key)
        {
            char x = 'A';
            int num = key % 3;
            if (num == 0)
                x = 'A';
            else if (num == 1)
                x = 'B';
            else if (num == 2)
                x = 'C';
            return x;
        }

        public List<string> plugConnections(int key)
        {
            List<string> lista = new List<string>();
            if(key < 10000)
            {
                return null;
            }

            int num = key % 26;
            List<char> letters = new List<char>();
            for (int i = 0; i < 10; i++)
            {
                char plug1 = alphabet[num];
                char plug2 = alphabet[(num + num) % 26];
                if (letters.Contains(plug1) || letters.Contains(plug2))
                    continue;
                string result = Convert.ToString(plug1) + Convert.ToString(plug2);
                lista.Add(result);
                num++;
            }
            
            return lista;
        }

        public void initialSettings(char[] ringSettings, char[] startingPositionOfTheRotors, string rotorOrder, char reflectorConfiguration, List<string> plugConnections)
        {

            if (ringSettings.Length != rotors.Length || startingPositionOfTheRotors.Length != rotors.Length)
            {
                throw new ArgumentException("Invalid argument lengths");
            }

            for (int i = 0; i < rotors.Length; i++)
            {
                rotors[i].ring = Char.ToUpper(ringSettings[i]);
                rotors[i].setOuterChar(Char.ToUpper(startingPositionOfTheRotors[i]));
            }



            Rotor rI = null;
            Rotor rII = null;
            Rotor rIII = null;

            for (int i = 0; i < rotors.Length; i++)
            {
                if (rotors[i].rotorNumber == "1")
                    rI = rotors[i];
                if (rotors[i].rotorNumber == "2")
                    rII = rotors[i];
                if (rotors[i].rotorNumber == "3")
                    rIII = rotors[i];
            }

            string[] order = rotorOrder.Split('-');
            for (int i = 0; i < order.Length; i++)
            {
                if (order[i] == "1")
                    rotors[i] = rI;
                if (order[i] == "2")
                    rotors[i] = rII;
                if (order[i] == "3")
                    rotors[i] = rIII;
            }



           if (reflectorConfiguration != 'A' && reflectorConfiguration != 'a' &&
                reflectorConfiguration != 'B' && reflectorConfiguration != 'b' &&
                reflectorConfiguration != 'C' && reflectorConfiguration != 'c')
            {
                throw new ArgumentException("Invalid argument");
            }

            char refCon = Char.ToUpper(reflectorConfiguration);
            string wiring = "";
            switch (refCon)
            {
                case 'A':
                    wiring = refA;
                    break;
                case 'B':
                    wiring = refB;
                    break;
                case 'C':
                    wiring = refC;
                    break;
            }
            reflector.setWiring(wiring);



            if (plugConnections == null)
                plugBoard.Clear();
            else
            {
                foreach (string plug in plugConnections)
                {
                    char[] letters = plug.ToCharArray();
                    addPlug(letters[0], letters[1]);
                }
            }
        }

        public void addPlug(char firstLetter, char secondLetter)
        {
            if (Char.IsLetter(firstLetter) && Char.IsLetter(secondLetter))
            {
                firstLetter = Char.ToUpper(firstLetter);
                secondLetter = Char.ToUpper(secondLetter);
                if (firstLetter != secondLetter && !plugBoard.ContainsKey(secondLetter))
                {
                    plugBoard.Add(firstLetter, secondLetter);
                    plugBoard.Add(secondLetter, firstLetter);
                }
            }
            else
            {
                throw new ArgumentException("Character is invalid");
            }
        }

        private void moveRotors(Rotor[] rot)
        {
            if (rot.Length == 3)
            {
                if (rot[1].isInTurnOver())
                {
                    rot[0].step();
                    rot[1].step();
                }
                else if (rot[2].isInTurnOver())
                {
                    rot[1].step();
                }
                rot[2].step();
            }
        }

        public string startEnigma(char[] text, int key)
        {
            //na osnovu kljuca postavljam rotore i ostale osnovne elemente masine
            char[] ringSettings = setRings(key);
            char[] startingPositionOfTheRotors = setRotorsPosition(key);
            string rotorOrder = setRotorOrder(key);
            char reflectorConf = setRefCon(key);
            List<string> plugs = plugConnections(key);

            initialSettings(ringSettings, startingPositionOfTheRotors, rotorOrder, reflectorConf, plugs);

            //pozivanje funkcije koja enkriptuje/dekriptuje
            string encryptedMessage = "";
            char character = 'A';
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                {
                    character = Char.ToUpper(text[i]);
                    encryptedMessage += encrypt_decryptCharacter(character).ToString();
                }
                else encryptedMessage += text[i].ToString();
            }
            return encryptedMessage;
        }

        public char encrypt_decryptCharacter(char c)
        {
            moveRotors(rotors);
            if (plugBoard.ContainsKey(c))
            {
                c = plugBoard[c];
            }

            c = rotorMap(c, false);
            c = reflectorMap(c);
            c = rotorMap(c, true);

            if (plugBoard.ContainsKey(c))
            {
                c = plugBoard[c];
            }
            return c;
        }

        private char rotorMap(char c, bool reverse)
        {
            int position = (int)c - 65;
            if (!reverse)
            {
                for (int i = rotors.Length - 1; i >= 0; i--)
                {
                    position = rotorValue(rotors[i], position, reverse);
                }
            }
            else
            {
                for (int i = 0; i < rotors.Length; i++)
                {
                    position = rotorValue(rotors[i], position, reverse);
                }
            }
            return alphabet.ToCharArray()[position];
        }

        private int rotorValue(Rotor rot, int position, bool reverse)
        {
            int rotorPosition = (int)rot.ring - 65;
        int x;
            if (!reverse)
                x = rot.map[(26 + position + rot.getOuterPosition() - rotorPosition) % 26];
            else
                x = rot.revMap[(26 + position + rot.getOuterPosition() - rotorPosition) % 26];

            int returnValue = (position + x) % 26;
            return returnValue;
        }

        private char reflectorMap(char c)
        {
            int position = (int)c - 65;
            int returnChar = (position + reflector.map[position]) % 26;
            return alphabet.ToCharArray()[returnChar];
        }
    }
}
