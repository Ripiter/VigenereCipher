using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenereCipher
{
    static class IndexData
    {
        /// <summary>
        /// Gets index of character from cypther array on <paramref name="keyValueIndex"/> dimension
        /// </summary>
        /// <param name="keyValueIndex"></param>
        /// <param name="lookingForChar"></param>
        /// <returns></returns>
        public static int GetIndexOfCharacterFromCypther(int keyValueIndex, char lookingForChar)
        {
            for (int i = 0; i < CyptherData.Cypher.GetLength(1); i++)
            {
                if (CyptherData.Cypher[keyValueIndex, i] == lookingForChar)
                    return i;
            }
            return 0;
        }

        /// <summary>
        /// Gets index of the character from the alphabet array
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        public static int GetIndexOfCharacter(char character)
        {
            for (int i = 0; i < CyptherData.Alphabet.Length; i++)
            {
                if (CyptherData.Alphabet[i] == character)
                    return i;
            }
            return 0;
        }
    }
}
