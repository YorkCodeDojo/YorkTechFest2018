using System;
using System.Linq;

namespace OsAndXs
{
    public enum Square
    {
        Empty = 0,
        X = 1,
        O = 2
    }

    public enum GameState
    {
        InProgress = 0,
        Draw = 1,
        WinForX = 2,
        WinForO = 3,
        Invalid = 4
    }

    public class Board
    {
        private readonly Square[][] _columns;
        private readonly Square[][] _rows;
        private readonly Square[][] _diagonals;


        public Board(Square cell00, Square cell10, Square cell20,
                     Square cell01, Square cell11, Square cell21,
                     Square cell02, Square cell12, Square cell22)
        {
            _columns = new Square[3][]
            {
                new Square[3] { cell00, cell01,cell02 },
                new Square[3] { cell10, cell11,cell12 },
                new Square[3] { cell20, cell21,cell22 }
            };

            _rows = new Square[3][]
            {
                new Square[3] { cell00, cell10,cell20 },
                new Square[3] { cell01, cell11,cell21 },
                new Square[3] { cell02, cell12, cell22 }
            };

            _diagonals = new Square[2][]
            {
                new Square[3] { cell00, cell11,cell22 },
                new Square[3] { cell20, cell11,cell02 },
            };
        }

        public GameState Evaluate()
        {
            bool CheckLinesForWin(Square[][] lines, Square square) =>
                lines.Any(column => column.Where(d => d == square).Count() == 3);

            var numberOfXs = _columns.Sum(cs => cs.Count(s => s == Square.X));
            var numberOfOs = _columns.Sum(cs => cs.Count(s => s == Square.O));
            if (Math.Abs(numberOfOs - numberOfXs) > 1) return GameState.Invalid;

            var winForX = CheckLinesForWin(_columns, Square.X) ||
                          CheckLinesForWin(_rows, Square.X) ||
                          CheckLinesForWin(_diagonals, Square.X);

            var winForO = CheckLinesForWin(_columns, Square.O) ||
                          CheckLinesForWin(_rows, Square.O) ||
                          CheckLinesForWin(_diagonals, Square.O);

            if (winForX && winForO)
                return GameState.Invalid;
            else if (winForX)
                return GameState.WinForX;
            else if (winForO)
                return GameState.WinForO;
            else if (numberOfXs + numberOfOs == 9)
                return GameState.Draw;
            else
                return GameState.InProgress;
        }


    }


}
