using System;
using System.Diagnostics;

namespace AdventOfCode2016.Day5.Classes
{
    public class PasswordDecryptor
    {
        public string DecryptWithPositioningFor(string doorId)
        {
            var index = 0;
            var result = "";
            var md5Calculator = new Md5HashCalculator();
            var numberOfFoundCharacters = 0;
            var passwordCharacters = new string[8];

            while (numberOfFoundCharacters < 8)
            {
                var md5 = md5Calculator.Calculate(doorId + index);

                if (md5.StartsWith("00000"))
                {
                    var position = md5.Substring(5, 1);
                    int convertedPosition = -1;

                    if (int.TryParse(position, out convertedPosition))
                    {
                        if (convertedPosition < 8 && 
                            string.IsNullOrEmpty(passwordCharacters[convertedPosition]))
                        {
                            passwordCharacters[convertedPosition] = md5.Substring(6, 1);
                            Debug.WriteLine(String.Join(string.Empty, passwordCharacters));
                            numberOfFoundCharacters++;
                        }
                    }
                }

                index++;
            }

            return result;
        }

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
