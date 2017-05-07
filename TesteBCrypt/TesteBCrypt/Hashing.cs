using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOne.Security.Cryptography.BCrypt;

namespace TesteBCrypt
{
    public class Hashing
    {
        private static string GetRandomSalt()
        {
            return BCryptHelper.GenerateSalt(12);
        }

        public static string HashPassword(string password)
        {
            return BCryptHelper.HashPassword(password, GetRandomSalt());
        }

        public static bool ValidatePassword(string password, string correctHash)
        {
            return BCryptHelper.CheckPassword(password, correctHash);
        }
    }
}
