using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2016.Day4
{
    public class LetterCounter
    {
        public IEnumerable<LetterCount> Count(string roomParts)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            var result = new List<LetterCount>();

            foreach (var character in alphabet)
            {
                var count = roomParts.Count(x => x == character);

                if (count > 0)
                {
                    result.Add(new LetterCount
                    {
                        Letter = character.ToString(),
                        Count = count
                    });
                }
            }
            
            return result.OrderByDescending(x => x.Count )
                .ThenBy(x => x.Letter)
                .ToList();
        }
    }
}