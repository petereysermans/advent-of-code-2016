using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2016.Day1
{
    public class BlockCalculator
    {
        private Direction _direction = Direction.North;

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

    public enum Direction
    {
        North,
        East,
        South,
        West
    }
}
