using System;
using System.Collections.Generic;

namespace AdventOfCode2016.Day2
{
    public class AdvancedKeyPad
    {
        private Dictionary<int, String[]> _buttons;
        private int _currentRow = 2;
        private int _currentColumn = 0;

        public AdvancedKeyPad()
        {
            _buttons = new Dictionary<int, string[]>
            {
                [0] = new[]
                {
                    null,
                    null,
                    "1",
                    null,
                    null
                },

                [1] = new[]
                {
                    null,
                    "2",
                    "3",
                    "4",
                    null
                },

                [2] = new[]
                {
                    "5",
                    "6",
                    "7",
                    "8",
                    "9"
                },

                [3] = new[]
                {
                    null,
                    "A",
                    "B",
                    "C",
                    null
                },

                [4] = new[]
                {
                    null,
                    null,
                    "D",
                    null,
                    null
                }
            };
        }

        private void Perform(char move)
        {
            switch (move)
            {
                case 'L':
                    if (_currentColumn > 0 &&
                        _buttons[_currentRow][_currentColumn-1] != null)
                    {
                        _currentColumn--;
                    }
                    break;
                case 'U':
                    if (_currentRow > 0 &&
                        _buttons[_currentRow-1][_currentColumn] != null)
                    {
                        _currentRow--;
                    }
                    break;
                case 'D':
                    if (_currentRow < 4 && 
                        _buttons[_currentRow+1][_currentColumn] != null)
                    {
                        _currentRow++;
                    }
                    break;
                case 'R':
                    if (_currentColumn < 4 &&
                        _buttons[_currentRow][_currentColumn+1] != null)
                    {
                        _currentColumn++;
                    }
                    break;
            }
        }

        public string Press(string moves)
        {
            foreach (var move in moves)
            {
                Perform(move);
            }

            return _buttons[_currentRow][_currentColumn];
        }

        public string ProcessMoveset(string moveset)
        {
            var moves = moveset.Split('\n');
            var result = string.Empty;

            foreach (var move in moves)
            {
                result += Press(move);
            }

            return result;
        }
    }
}
