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
        public Board(Square cell00, Square cell10, Square cell20, 
                     Square cell01, Square cell11, Square cell21,
                     Square cell02, Square cell12, Square cell22)
        {
        }

        public GameState Evaluate()
        {
            return GameState.InProgress;
        }
    }
}
