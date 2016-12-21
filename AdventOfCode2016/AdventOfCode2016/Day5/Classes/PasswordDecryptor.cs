using System;
using System.Diagnostics;

namespace AdventOfCode2016.Day5.Classes
{
    public class PasswordDecryptor
    {
        public string DecryptFor(string doorId)
        {
            var index = 0;
            var result = "";
            var md5Calculator = new Md5HashCalculator();

            while (result.Length < 8)
            {
                var md5 = md5Calculator.Calculate(doorId + index);

                if (md5.StartsWith("00000"))
                {
                    result += md5.Substring(5, 1);
                    Debug.WriteLine("password: " + result);
                }

                index++;
            }

            return result;
        }
    }
}
