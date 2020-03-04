using System;

namespace VigenereCipher
{
    class Program
    {
        static char[] movingArray = new char[26];
        static char[] alphabet = new char[26];
        static char[,] cypher = new char[26, 26];

        static void Main(string[] args)
        {
            for (int i = 97; i < 123; i++)
                alphabet[i - 97] = (char)i;

            Array.Copy(alphabet, movingArray, alphabet.Length);

            for (int i = 0; i < cypher.GetLength(0); i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    cypher[i, j] = movingArray[j];
                }
                MoveArray();
            }

            string message = "helloWorld";
            string key = "key";

            char[] messageArray = message.ToLower().ToCharArray();
            char[] keyArray = key.ToLower().ToCharArray();
            //int keyNum = 0;
            //for (int i = 0; i < messageArray.Length; i++)
            //{
            //    if (keyNum >= keyArray.Length)
            //        keyNum = 0;

            //    int keyIndex = GetIndexOfCharacter(keyArray[keyNum]);
            //    int messageIndex = GetIndexOfCharacter(messageArray[i]);

            //    //Console.WriteLine(cypher[keyIndex, messageIndex]);

            //    keyNum++;
            //}



            //https://www.dcode.fr/vigenere-cipher
            string encMessage = "rijvsuyvjn";
            int keyDecode = 0;

            char[] encMessageArray = encMessage.ToLower().ToCharArray();

            for (int i = 0; i < encMessageArray.Length; i++)
            {
                // Loops thru the keyValues
                if (keyDecode >= keyArray.Length)
                    keyDecode = 0;

                int a = GetIndexOfCharacter(keyArray[keyDecode]);
                int c = GetIndexOfCharacterFromCypther(a, encMessageArray[i]);
                
                
                Console.WriteLine(alphabet[c]);
                keyDecode++;
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Gets index of character from cypther array on <paramref name="keyValueIndex"/> dimension
        /// </summary>
        /// <param name="keyValueIndex"></param>
        /// <param name="lookingForChar"></param>
        /// <returns></returns>
        static int GetIndexOfCharacterFromCypther(int keyValueIndex, char lookingForChar)
        {
            for (int i = 0; i < cypher.GetLength(1); i++)
            {
                if (cypher[keyValueIndex, i] == lookingForChar)
                    return i;
            }
            return 0;
        }

        /// <summary>
        /// Gets index of the character from the alphabet array
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        static int GetIndexOfCharacter(char character)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == character)
                    return i;
            }
            return 0;
        }
        


        /// <summary>
        /// Moves all values in array 1 to the left and puts the first one in the last place
        /// </summary>
        static void MoveArray()
        {
            char temp = movingArray[0];

            for (int i = 0; i < movingArray.Length; i++)
            {
                if (i + 1 != movingArray.Length)
                    movingArray[i] = movingArray[i + 1];
            }
            
            movingArray[movingArray.Length - 1] = temp;
        }

    }
}
