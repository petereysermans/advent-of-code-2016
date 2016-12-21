using System;
using System.Linq;

namespace AdventOfCode2016.Day4
{
    public class Room
    {
        private readonly LetterCounter _letterCounter;
        private readonly string _encryptedName;

        public Room(string encryptedName)
        {
            _letterCounter = new LetterCounter();
            _encryptedName = encryptedName;
        }

        public int IsReal()
        {
            var encryptedNameWithoutChecksum = 
                _encryptedName.Substring(0, _encryptedName.LastIndexOf("-", StringComparison.Ordinal));
            var letterCounts = _letterCounter.Count(encryptedNameWithoutChecksum);

            var calculatedCheckSum = String.Join(string.Empty, letterCounts 
                                                                    .Take(5)
                                                                    .Select(x => x.Letter).ToArray());

            var startOfCheckSum = _encryptedName.IndexOf("[", StringComparison.Ordinal)+1;
            var checkSum = _encryptedName.Substring(startOfCheckSum, _encryptedName.Length -1 - startOfCheckSum);

            if (checkSum == calculatedCheckSum)
            {
                var startOfSectorId = _encryptedName.LastIndexOf("-", StringComparison.Ordinal) + 1;
                var endOfSectorId = _encryptedName.LastIndexOf("[", StringComparison.Ordinal);
                var sectorId = _encryptedName.Substring(
                    startOfSectorId,
                    endOfSectorId - startOfSectorId);

                return int.Parse(sectorId);
            }

            return -1;
        }
    }
}