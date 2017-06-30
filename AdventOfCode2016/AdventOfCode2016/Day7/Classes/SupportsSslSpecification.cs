using System.Collections.Generic;

namespace AdventOfCode2016.Day7.Classes
{
    public class SupportsSslSpecification
    {
        public bool IsSatisfied(string input)
        {
            var supportsSsl = false;
            var hypernetSequence = false;

            var foundAbaBlocks = FindAbaBlocks(input);

            foreach (var abaBlock in foundAbaBlocks)
            {
                if (AbaBlockHasCorrespondingBabBlock(input, abaBlock))
                {
                    return true;
                }
            }

            return false;
        }

        private bool AbaBlockHasCorrespondingBabBlock(string input, string abaBlock)
        {
            var hypernetSequence = false;

            for (var i = 0; i <= input.Length - 3; i++)
            {
                var char1 = input[i];
                var char2 = input[i + 1];
                var char3 = input[i + 2];

                if (char1 == '[')
                {
                    hypernetSequence = true;
                }

                if (char1 == ']')
                {
                    hypernetSequence = false;
                }

                if (hypernetSequence)
                {
                    if (char2 == abaBlock[0] &&
                        char1 == char3 &&
                        char1 == abaBlock[1])
                    {
                        return true;
                    }
                }

            }

            return false;
        }

        private List<string> FindAbaBlocks(string input)
        {
            var hypernetSequence = false;
            var foundAbaBlocks = new List<string>();

            for (var i = 0; i <= input.Length-3; i++)
            {
                var char1 = input[i];
                var char2 = input[i + 1];
                var char3 = input[i + 2];

                if (char1 == '[')
                {
                    hypernetSequence = true;
                }

                if (char1 == ']')
                {
                    hypernetSequence = false;
                }

                if (char1 == char3 &&
                    char1 != char2)
                {
                    if (!hypernetSequence)
                    {
                        foundAbaBlocks.Add($"{char1}{char2}{char3}");
                    }

                }
            }

            return foundAbaBlocks;
        }
    }
}
