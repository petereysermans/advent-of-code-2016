using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2016.Day6.Classes
{
    public class MessageDecoder
    {
        private string GetMostFrequentCharacter(Dictionary<string, int> countedCharacters)
        {
            return countedCharacters.First(x => x.Value == countedCharacters.Max(y => y.Value)).Key;
        }

        private string GetLeastFrequentCharacter(Dictionary<string, int> countedCharacters)
        {
            return countedCharacters.First(x => x.Value == countedCharacters.Min(y => y.Value)).Key;
        }

        private string GetCharacterForColumn(
            string[] inputParts, 
            int column, 
            Func<Dictionary<string, int>, string> getCharacter )
        {
            var countedCharacters = new Dictionary<string, int>();

            foreach(var inputPart in inputParts)
            {
                var character = inputPart.Trim()[column].ToString();

                if (countedCharacters.ContainsKey(character))
                {
                    countedCharacters[character]++;
                }
                else
                {
                    countedCharacters.Add(character, 1);
                }
            }

            return getCharacter(countedCharacters);
        }

        private string Decode(string input, Func<Dictionary<string, int>, string> getCharacter)
        {
            var decodedMessage = string.Empty;
            var inputParts = input.Split('\n');
            var numberOfCharacters = inputParts.First().Trim().Length;

            for (var i = 0; i < numberOfCharacters; i++)
            {
                decodedMessage += GetCharacterForColumn(inputParts, i, getCharacter);
            }

            return decodedMessage;
        }

        public string DecodeUsingLeastFrequentCharacters(string input)
        {
            return Decode(input, GetLeastFrequentCharacter);
        }

        public string DecodeUsingMostFrequentCharacters(string input)
        {
            return Decode(input, GetMostFrequentCharacter);
        }
    }
}