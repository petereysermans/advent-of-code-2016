using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Input = AdventOfCode2016.Day6.Classes.Input;

namespace AdventOfCode2016.Day6.TestFixtures
{
    [TestFixture]
    public class When_solving_part_1
    {
        [Test]
        public void Then_the_test_case_should_pass()
        {
            var decoder = new MessageDecoder();
            var result = decoder.Decode(Input.Test);
            Assert.That(result, Is.EqualTo("easter"));
        }

        [Test]
        public void Then_the_puzzle_can_be_solved()
        {
            var decoder = new MessageDecoder();
            var result = decoder.Decode(Input.Text);
        }
    }

    public class MessageDecoder
    {
        private string GetMostFrequentCharacterForColumn(string[] inputParts, int column)
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

            var totalCountedCharacters = countedCharacters.Sum(x => x.Value);
            return countedCharacters.First(x => x.Value == countedCharacters.Max(y => y.Value)).Key;
        }

        public string Decode(string input)
        {
            var decodedMessage = string.Empty;
            var inputParts = input.Split('\n');
            var numberOfCharacters = inputParts.First().Trim().Length;

            for (var i = 0; i < numberOfCharacters; i++)
            {
                decodedMessage += GetMostFrequentCharacterForColumn(inputParts, i);
            }

            return decodedMessage;
        }
    }
}
