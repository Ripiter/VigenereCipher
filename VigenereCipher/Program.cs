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
            Vigenere vigenere = new Vigenere();
            CyptherData.GenerateData();

            string message = "helloWorld";
            string key = "key";
            
            string temp = vigenere.Encrypt(key, message);
            Console.WriteLine(temp);


            string reTemp = vigenere.Decrypt(key, temp);
            Console.WriteLine(reTemp);


            Console.ReadKey();
        }
    }
}
