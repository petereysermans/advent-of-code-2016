using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace AdventOfCode2016.Day3
{
    public static class TriangleStringExtension
    {
        public static List<int> GetSides(this string sides)
        {
            return sides.Split(' ')
                    .Where(x => !string.IsNullOrEmpty(x))
                    .Select(int.Parse)
                    .ToList();
        }
    }
}
