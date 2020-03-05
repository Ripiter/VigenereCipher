using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenereCipher
{
    class Vigenere
    {
        public string Encrypt(string key, string message)
        {
            string encryptedString = string.Empty;
            char[] messageArray = message.ToLower().ToCharArray();
            char[] keyArray = key.ToLower().ToCharArray();

            int keyNum = 0;
            for (int i = 0; i < messageArray.Length; i++)
            {
                if (keyNum >= keyArray.Length)
                    keyNum = 0;

                int keyIndex = IndexData.GetIndexOfCharacter(keyArray[keyNum]);
                int messageIndex = IndexData.GetIndexOfCharacter(messageArray[i]);

                encryptedString += CyptherData.Cypher[keyIndex, messageIndex];
                keyNum++;
            }

            return encryptedString;
        }

        //https://www.dcode.fr/vigenere-cipher
        public string Decrypt(string key, string encMessage)
        {
            string decryptedString = string.Empty;

            int keyDecode = 0;
            char[] encMessageArray = encMessage.ToLower().ToCharArray();
            char[] keyArray = key.ToLower().ToCharArray();

            for (int i = 0; i < encMessageArray.Length; i++)
            {
                // Loops thru the keyValues
                if (keyDecode >= keyArray.Length)
                    keyDecode = 0;

                int a = IndexData.GetIndexOfCharacter(keyArray[keyDecode]);
                int c = IndexData.GetIndexOfCharacterFromCypther(a, encMessageArray[i]);


                decryptedString += CyptherData.Alphabet[c];
                keyDecode++;
            }

            return decryptedString;
        }
    }
}
