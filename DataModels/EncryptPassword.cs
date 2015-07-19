using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace DataModels
{
    public class EncryptPassword
    {
        public static string Encrypt(string input)
        {
            SHA1 encrypt = SHA1.Create();
            byte[] key = encrypt.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder protectedString = new StringBuilder();

            for (int i = 0; i < key.Length; i++)
                protectedString.Append(key[i].ToString());

            return protectedString.ToString();
        }
    }

}

