using Xunit;

namespace OsAndXs.Tests
{
    public class TheGameIsAWinForO
    {
        [Fact]
        public void GivenAVerticalWinForO()
        {
            var board = new Board(Square.O, Square.X, Square.X,
                                  Square.O, Square.Empty, Square.Empty,
                                  Square.O, Square.Empty, Square.Empty);

            var gameState = board.Evaluate();

            Assert.Equal(GameState.WinForO, gameState);
        }

        [Fact]
        public void GivenAHorizontalWinForO()
        {
            var board = new Board(Square.O, Square.X, Square.X,
                                  Square.O, Square.O, Square.O,
                                  Square.X, Square.Empty, Square.Empty);

            var gameState = board.Evaluate();

            Assert.Equal(GameState.WinForO, gameState);
        }

        [Fact]
        public void GivenADiagonalWinForO()
        {
            var board = new Board(Square.O, Square.X, Square.X,
                                  Square.O, Square.O, Square.Empty,
                                  Square.X, Square.Empty, Square.O);

            var gameState = board.Evaluate();

            Assert.Equal(GameState.WinForO, gameState);
        }

        [Fact]
        public void GivenAReverseDiagonalWinForO()
        {
            var board = new Board(Square.X, Square.X, Square.O,
                                  Square.O, Square.O, Square.Empty,
                                  Square.O, Square.Empty, Square.X);

            var gameState = board.Evaluate();

            Assert.Equal(GameState.WinForO, gameState);
        }

    }
}
