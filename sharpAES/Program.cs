using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
namespace sharpAes
{
    public class SharpAes
    {
        protected string? plaintext = "";
        protected string password = "";
        protected int level = 0;

        SharpAes() 
        {
            Console.WriteLine("sharpAES v0.1");
            plaintext = GetPlainText();
            level = GetLevel();

        }

        protected int GetLevel()
        {
            bool valid = false;
            string value = "";
            Console.WriteLine("To use AES-128, please enter 1. To use AES-192, please enter 2. To use AES-256, please enter 3. ");
            value = Console.ReadLine()!;
            while (valid == false)
            {
                valid = int.TryParse(value, out level);
            }
            return level;
        }

        protected string GetPlainText()
        {
            bool valid = false;
            Console.WriteLine("Please enter the plaintext below: ");
            while (valid == false)
            {
                plaintext = Console.ReadLine();
                if (plaintext == null)
                {
                    Console.WriteLine("The plaintext cannot be null. Please enter valid plaintext below: ");
                }
                else
                {
                    Console.WriteLine("Plaintext accepted. ");
                }
            }
            return plaintext;
        }

        protected string GetPassword()
        {
            return "this is not secure now.";
        }

        protected void GenerateKey(string password)
        {

        }

        protected string Encrypt()
        {
            Console.WriteLine("Temp");
            return "hello";
        }
    }
}
