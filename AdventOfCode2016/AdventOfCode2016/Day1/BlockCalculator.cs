using System;
using System.Collections.Generic;

namespace AdventOfCode2016.Day1
{
    public class BlockCalculator
    {
        private Direction _direction = Direction.North;
        private List<String> _visitedCoordinates = new List<string>();
        private int _currentXCoordinate = 0;
        private int _currentYCoordinate = 0;
        private string _firstDoubleVisitedCoordinate;

        private Dictionary<Direction, int> _numberOfBlocksPerDirection;

        public BlockCalculator()
        {
            _numberOfBlocksPerDirection = new Dictionary<Direction, int>
            {
                { Direction.North, 0 },
                { Direction.East, 0 },
                { Direction.South, 0 },
                { Direction.West, 0 }
            };
        }

        public string FirstDoubleVisitedCoordinate => _firstDoubleVisitedCoordinate;

        private void DetermineDirection(char currentMove)
        {
            if (currentMove == 'R')
            {
                switch (_direction)
                {
                    case Direction.North:
                        _direction = Direction.East;
                        break;
                    case Direction.East:
                        _direction = Direction.South;
                        break;
                    case Direction.West:
                        _direction = Direction.North;
                        break;
                    case Direction.South:
                        _direction = Direction.West;
                        break;
                }
            }
            else
            {
                switch (_direction)
                {
                    case Direction.North:
                        _direction = Direction.West;
                        break;
                    case Direction.East:
                        _direction = Direction.North;
                        break;
                    case Direction.West:
                        _direction = Direction.South;
                        break;
                    case Direction.South:
                        _direction = Direction.East;
                        break;
                }
            }
        }

        private void CountNumberOfBlocks(string move)
        {
            move = move.Trim();
            var numberOfBlocksToMove = int.Parse(move.Substring(1));
            DetermineDirection(move[0]);

            if (string.IsNullOrEmpty(_firstDoubleVisitedCoordinate))
            {
                for (var i = 1; i <= numberOfBlocksToMove; i++)
                {
                    switch (_direction)
                    {
                        case Direction.North:
                            _currentXCoordinate++;
                            break;
                        case Direction.East:
                            _currentYCoordinate++;
                            break;
                        case Direction.South:
                            _currentXCoordinate--;
                            break;
                        case Direction.West:
                            _currentYCoordinate--;
                            break;
                    }

                    var currentCoordinate = _currentXCoordinate + "_" + _currentYCoordinate;

                    if (!_visitedCoordinates.Contains(currentCoordinate))
                    {
                        _visitedCoordinates.Add(currentCoordinate);
                    }
                    else
                    {
                        _firstDoubleVisitedCoordinate = currentCoordinate;
                    }
                }
            }

            _numberOfBlocksPerDirection[_direction] += numberOfBlocksToMove;
        }

        public int Calculate(string moveset)
        {
            var moves = moveset.Split(',');

            foreach (var move in moves)
            {
                CountNumberOfBlocks(move);
            }

            return Math.Abs(
                _numberOfBlocksPerDirection[Direction.North] - 
                _numberOfBlocksPerDirection[Direction.South]) + 
                Math.Abs(
                _numberOfBlocksPerDirection[Direction.East] - 
                _numberOfBlocksPerDirection[Direction.West]);
        }
    }
}
