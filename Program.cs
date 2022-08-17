using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
namespace RSA
{
    class Program
    {
        static void Main(string[] args)
        {

            RSACryptoServiceProvider myrsa = new RSACryptoServiceProvider();

            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();//Encode String to Convert to Bytes

            string data = "RsA EnCryPTion is cool!!!";//whatever you want to encrypt

            Byte[] newdata = encoding.GetBytes(data);//convert to Bytes

            Byte[] encrypted = myrsa.Encrypt(newdata, false);

            Console.WriteLine("Encrypted Data:  ");
            for (int i = 0; i < encrypted.Length; i++)
            {
                Console.Write("{0} ", encrypted[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            Byte[] decrypted = myrsa.Decrypt(encrypted, false);//decrypt 
            Console.WriteLine("Decrypted Data:  ");

            string dData = encoding.GetString(decrypted); //encode bytes back to string 
            for (int i = 0; i < decrypted.Length; i++)
            {
                Console.Write("{0}", dData[i]);
            }

        }
    }
}