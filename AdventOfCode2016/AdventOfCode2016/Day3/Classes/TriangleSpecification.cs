using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2016.Day3
{
    public class TriangleSpecification
    {
        public int CountVerticalPossibleTriangles(
            List<int> firstLineSides,
            List<int> secondLineSides,
            List<int> thirdLineSides)
        {
            var numberOfPossibleTriangles = 0;

            if (IsTriangle(firstLineSides[0], secondLineSides[0], thirdLineSides[0]))
            {
                numberOfPossibleTriangles++;
            }

            if (IsTriangle(firstLineSides[1], secondLineSides[1], thirdLineSides[1]))
            {
                numberOfPossibleTriangles++;
            }

            if (IsTriangle(firstLineSides[2], secondLineSides[2], thirdLineSides[2]))
            {
                numberOfPossibleTriangles++;
            }

            return numberOfPossibleTriangles;
        }

        public bool IsTriangle(int firstSide, int secondSide, int thirdSide)
        {
            var result = IsTriangle(new List<int>
            {
                firstSide, secondSide, thirdSide
            });

            var log = firstSide + " " + secondSide + " " + thirdSide + ": " + result;
            Console.WriteLine(log);

            return result;
        }

        public bool IsTriangle(List<int> sides)
        {
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

            if (solution1 != solution2)
            {
                Console.WriteLine("incorrect");
            }

            return solution1;
        }

        public bool IsTriangle(string input)
        {
            return IsTriangle(input.GetSides());
        }
    }
}
