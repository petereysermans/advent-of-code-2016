namespace AdventOfCode2016.Day2
{
    public class KeyPad
    {
        private int[,] _buttons = new int[3,3];
        private int _currentRow = 1;
        private int _currentColumn = 1;
        private string _result;


        public KeyPad()
        {
            var counter = 1;

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    _buttons[i, j] = counter;
                    counter++;
                }
            }
        }

        private void Perform(char move)
        {
            switch (move)
            {
                case 'L':
                    if (_currentColumn > 0)
                    {
                        _currentColumn--;
                    }
                    break;
                case 'U':
                    if (_currentRow > 0)
                    {
                        _currentRow--;
                    }
                    break;
                case 'D':
                    if (_currentRow < 2)
                    {
                        _currentRow++;
                    }
                    break;
                case 'R':
                    if (_currentColumn < 2)
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

            return _buttons[_currentRow, _currentColumn].ToString();
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
