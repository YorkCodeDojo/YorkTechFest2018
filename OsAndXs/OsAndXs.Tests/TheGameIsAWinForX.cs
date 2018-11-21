using Xunit;

namespace OsAndXs.Tests
{
    public class TheGameIsAWinForX
    {
        [Fact]
        public void GivenAVerticalWinForX()
        {
            var board = new Board(Square.X, Square.O, Square.O,
                                  Square.X, Square.Empty, Square.Empty,
                                  Square.X, Square.Empty, Square.Empty);

            var gameState = board.Evaluate();

            Assert.Equal(GameState.WinForX, gameState);
        }

        [Fact]
        public void GivenAHorizontalWinForX()
        {
            var board = new Board(Square.X, Square.O, Square.O,
                                  Square.X, Square.X, Square.X,
                                  Square.O, Square.Empty, Square.Empty);

            var gameState = board.Evaluate();

            Assert.Equal(GameState.WinForX, gameState);
        }

        [Fact]
        public void GivenADiagonalWinForX()
        {
            var board = new Board(Square.X, Square.O, Square.O,
                                  Square.X, Square.X, Square.Empty,
                                  Square.O, Square.Empty, Square.X);

            var gameState = board.Evaluate();

            Assert.Equal(GameState.WinForX, gameState);
        }

        [Fact]
        public void GivenAReverseDiagonalWinForX()
        {
            var board = new Board(Square.O, Square.O, Square.X,
                                  Square.X, Square.X, Square.Empty,
                                  Square.X, Square.Empty, Square.O);

            var gameState = board.Evaluate();

            Assert.Equal(GameState.WinForX, gameState);
        }

    }
}
