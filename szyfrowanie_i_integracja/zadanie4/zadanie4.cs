using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class RSACryptoTool
{
    static void Main()
    {
        string filePath = "plik.txt";
        string publicKeyPath = "klucz_publiczny.pem";
        string privateKeyPath = "klucz_prywatny.pem";

        
        using (RSA rsa = RSA.Create())
        {
           
            string publicKey = rsa.ToXmlString(false);
            File.WriteAllText(publicKeyPath, publicKey);

            
            string privateKey = rsa.ToXmlString(true);
            File.WriteAllText(privateKeyPath, privateKey);
        }

       
        EncryptFile(filePath, publicKeyPath);

        
        DecryptFile("plik_zaszyfrowany.txt", privateKeyPath);
    }

    static void EncryptFile(string filePath, string publicKeyPath)
    {
        byte[] fileBytes = File.ReadAllBytes(filePath);

        using (RSA rsa = RSA.Create())
        {
            rsa.FromXmlString(File.ReadAllText(publicKeyPath));
            byte[] encryptedBytes = rsa.Encrypt(fileBytes, RSAEncryptionPadding.OaepSHA256);
            File.WriteAllBytes("plik_zaszyfrowany.txt", encryptedBytes);
        }

        Console.WriteLine("Plik został zaszyfrowany.");
    }

    static void DecryptFile(string encryptedFilePath, string privateKeyPath)
    {
        byte[] encryptedBytes = File.ReadAllBytes(encryptedFilePath);

        using (RSA rsa = RSA.Create())
        {
            rsa.FromXmlString(File.ReadAllText(privateKeyPath));
            byte[] decryptedBytes = rsa.Decrypt(encryptedBytes, RSAEncryptionPadding.OaepSHA256);
            File.WriteAllBytes("plik_odczytany.txt", decryptedBytes);
        }

        Console.WriteLine("Plik został odszyfrowany.");
    }
}
