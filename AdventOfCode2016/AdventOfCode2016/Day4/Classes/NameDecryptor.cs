using System;

namespace AdventOfCode2016.Day4
{
    public class NameDecryptor
    {
        public string Decrypt(string encryptedName)
        {
            var encryptedNameWithoutChecksum = encryptedName.Substring(0,
                 encryptedName.LastIndexOf("-", StringComparison.Ordinal));
            var nameParts = encryptedName.Split('-');
            var checksum = nameParts[nameParts.Length-1];
            checksum = checksum.Substring(0, checksum.IndexOf("[", StringComparison.Ordinal));
            var checksumAsInt = int.Parse(checksum);
            var result = "";

            foreach (var character in encryptedNameWithoutChecksum)
            {
                if (character == '-')
                {
                    result += " ";
                    continue;
                }

                int currentCode = character;

                for (var i = 0; i < checksumAsInt; i++)
                {
                    currentCode++;

                    if (currentCode > 'z')
                    {
                        currentCode = 'a';
                    }
                }

                result += (char) currentCode;
            }

            return result;
        }
    }
}
