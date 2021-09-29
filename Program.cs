using System;
using System.Security.Cryptography;
using System.Text;

namespace EncryptDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {

            var key = "b14ca5898a4e4133bbce2ea2315a1916";

            //Console.WriteLine("Please enter a secret key for the symmetric algorithm.");  
            //var key = Console.ReadLine();  

            Console.Write("Please enter a string for encryption: ");
            var str = Console.ReadLine();
            var encryptedString = AesOperation.EncryptString(key, str);
            Console.WriteLine($"encrypted string = {encryptedString}");

            var decryptedString = AesOperation.DecryptString(key, encryptedString);
            Console.WriteLine($"decrypted string = {decryptedString}");

            Console.ReadKey();


        }


    }
}
