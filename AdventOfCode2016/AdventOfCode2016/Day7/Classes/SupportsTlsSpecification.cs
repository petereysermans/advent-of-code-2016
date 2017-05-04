namespace AdventOfCode2016.Day7.Classes
{
    public class SupportsTlsSpecification
    {
        public bool IsSatisfied(string input)
        {
            var supportsTls = false;
            var hypernetSequence = false;

            for (var i = 0; i <= input.Length-4; i++)
            {
                var char1 = input[i];
                var char2 = input[i + 1];
                var char3 = input[i + 2];
                var char4 = input[i + 3];


                if (char1 == '[')
                {
                    hypernetSequence = true;
                }

                if (char1 == ']')
                {
                    hypernetSequence = false;
                }

                if (char1 == char4 &&
                    char2 == char3 &&
                    char1 != char2)
                {
                    if (hypernetSequence)
                    {
                        supportsTls = false;
                        break;
                    }

                    supportsTls = true;
                }
            }

            return supportsTls;
        }
    }
}