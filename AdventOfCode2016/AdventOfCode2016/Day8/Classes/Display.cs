using System;

namespace AdventOfCode2016.Day8.Classes
{
    public class Display
    {
        private string[,] _dots;

        public Display()
        {
            _dots = new string[6, 50];

            for (var i = 0; i < _dots.GetLength(0); i++)
            {
                for (var j = 0; j < _dots.GetLength(1); j++)
                {
                    _dots[i, j] = ".";
                }
            }
        }

        public void Print()
        {
            Console.Write(Environment.NewLine);

            for (var i = 0; i < _dots.GetLength(0); i++)
            {
                for (var j = 0; j < _dots.GetLength(1); j++)
                {
                    Console.Write(_dots[i,j]);
                }

                Console.Write(Environment.NewLine);
            }
        }

        public void Instruct(string instruction)
        {
            var instructionParts = instruction.Split(' ');
            var dimensionParts = instructionParts[1].Split('x');

            if (instructionParts[0] == "rect")
            {
                DrawRect(instructionParts[1]);
            }
            else if(instructionParts[1] == "rotate")
            {
                
            }
        }

        private void rotate(string parameters)
        {
            var parametersParts = 
        }

        private void DrawRect(string dimension)
        {
            var dimensionParts = dimension.Split('x');
            var dimensionWidth = int.Parse(dimensionParts[0]);
            var dimensionHeight = int.Parse(dimensionParts[1]);

            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    _dots[i, j] = "#";
                }
            }
        }
    }
}
