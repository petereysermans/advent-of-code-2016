using System;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using NUnit.Framework;

namespace AdventOfCode2016.Day3
{
    public class TriangleSpecification
    {
        public bool IsTriangle(string input)
        {
            var sides = input.Replace("  ", " ")
                             .Replace("   ", " ")
                             .Split(' ')
                             .Where(x => !string.IsNullOrEmpty(x))
                             .Select(Int32.Parse)
                             .ToList();

            var lowestNumber = sides.Min();
            var highestNumber = sides.Max();

            var a = sides[0];
            var b = sides[1];
            var c = sides[2];

            sides.Remove(lowestNumber);
            sides.Remove(highestNumber);

            var middleNumber = sides.First();
            
            var solution1 = (lowestNumber + middleNumber) > highestNumber;

            var solution2 = ((a + b) > c) &&
                   ((c + b) > a) &&
                   ((a + c) > b);

            return solution1;
        }
    }
}
