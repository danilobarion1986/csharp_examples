using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBCrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashedPassword = Hashing.HashPassword("teste");

            Console.WriteLine("Informe o password: ");
            var pwd = Console.ReadLine();

            if (Hashing.ValidatePassword(pwd, hashedPassword))
            {
                Console.WriteLine("Passsword correto!");
            }
            else
            {
                Console.WriteLine("Passsword errado!");
            }

            Console.ReadKey();
        }
    }
}
