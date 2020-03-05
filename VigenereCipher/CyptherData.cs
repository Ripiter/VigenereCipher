using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenereCipher
{
    class CyptherData
    {
        static char[] movingArray = new char[26];
        static char[] alphabet = new char[26];
        static char[,] cypher = new char[26, 26];

        public static char[,] Cypher { get => cypher; set => cypher = value; }
        public static char[] Alphabet { get => alphabet; set => alphabet = value; }
        public static char[] MovingArray { get => movingArray; set => movingArray = value; }

        public static void GenerateData()
        {
            for (int i = 97; i < 123; i++)
                Alphabet[i - 97] = (char)i;

            Array.Copy(Alphabet, MovingArray, Alphabet.Length);

            for (int i = 0; i < Cypher.GetLength(0); i++)
            {
                for (int j = 0; j < Alphabet.Length; j++)
                {
                    Cypher[i, j] = MovingArray[j];
                }
                MoveArray();
            }
        }

        /// <summary>
        /// Moves all values in array 1 to the left and puts the first one in the last place
        /// </summary>
        static void MoveArray()
        {
            char temp = MovingArray[0];

            for (int i = 0; i < MovingArray.Length; i++)
            {
                if (i + 1 != MovingArray.Length)
                    MovingArray[i] = MovingArray[i + 1];
            }

            MovingArray[MovingArray.Length - 1] = temp;
        }
    }
}
