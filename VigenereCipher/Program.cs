using System;

namespace VigenereCipher
{
    class Program
    {
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
