using System;
using System.Security.Cryptography;
using System.Text;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter string: ");
        string inputString = Console.ReadLine();
        string hashedString;

        byte[] bytes = Encoding.UTF8.GetBytes(inputString);
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] hashBytes = sha256.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
            }
            hashedString = sb.ToString();
        }

        Console.WriteLine($"Hashed string: {hashedString}");
    }
}