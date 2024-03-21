using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
namespace sharpAes
{
    public class SharpAes
    {
        protected string plaintext = "";
        protected string password = "";
        protected int level = 0;

        SharpAes() 
        {
            Console.WriteLine("sharpAES v0.1");
            plaintext = GetPlainText();

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

        protected string Encrypt()
        {
            Console.WriteLine("Temp");
            return "hello";
        }
    }
}
