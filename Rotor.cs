using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    class Rotor
    {
        private const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private int outerPosition;
        public char outerChar { get; set; }
        private string wiring;
        private char turnOverOnDifferentLetter;
        public string rotorNumber { get; set; }
        public char ring { get; set; }
        public int[] map { get; }
        public int[] revMap { get; }

        public Rotor(string wiring, char letter, string number)
        {
            map = new int[26];
            revMap = new int[26];
            //turnOverOnDifferentLetter = letter;
            rotorNumber = number;
            ring = 'A';
            outerPosition = 0;
            setWiring(wiring);
        }

        public void setWiring(string wire)
        {
            wiring = wire;
            outerChar = wiring.ToCharArray()[outerPosition];

            for (int i = 0; i < 26; i++)
            {
                char letter = wiring.ToCharArray()[i];
                int num = (int)letter - 65;
                map[i] = (26 + num - i) % 26;
                revMap[i] = (26 + i - num) % 26;
            }
        }

        public void setOuterPosition(int index)
        {
            outerPosition = index;
            outerChar = alphabet.ToCharArray()[outerPosition];
        }

        public int getOuterPosition()
        {
            return outerPosition;
        }

        public void setOuterChar(char character)
        {
            outerChar = character;
            outerPosition = alphabet.IndexOf(outerChar);
        }

        public void step()
        {
            outerPosition = (outerPosition + 1) % 26;
            outerChar = alphabet.ToCharArray()[outerPosition];
        }

        public bool isInTurnOver()
        {
            return outerChar == turnOverOnDifferentLetter;
        }
    }
}
