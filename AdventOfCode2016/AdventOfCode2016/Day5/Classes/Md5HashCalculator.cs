using System;
using System.Security.Cryptography;
using System.Text;

namespace AdventOfCode2016.Day5.Classes
{
    public class Md5HashCalculator
    {
        public string Calculate(string password)
        {
            // byte array representation of that string
            byte[] encodedPassword = new UTF8Encoding().GetBytes(password);

            // need MD5 to calculate the hash
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

            // string representation (similar to UNIX format)
            return BitConverter.ToString(hash)
               // without dashes
               .Replace("-", string.Empty)
               // make lowercase
               .ToLower();
        }
    }
}
