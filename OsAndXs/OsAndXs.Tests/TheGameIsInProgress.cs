using Xunit;

namespace OsAndXs.Tests
{
    public class TheGameIsInProgress
    {
        [Fact]
        public void GivenAnEmptyBoard()
        {
            var board = new Board(Square.Empty, Square.Empty, Square.Empty,
                                  Square.Empty, Square.Empty, Square.Empty,
                                  Square.Empty, Square.Empty, Square.Empty);

            var gameState = board.Evaluate();

            Assert.Equal(GameState.InProgress, gameState);
        }

        [Fact]
        public void GivenAMixedFirstColumn()
        {
            var board = new Board(Square.X, Square.X, Square.O,
                                  Square.O, Square.Empty, Square.Empty,
                                  Square.X, Square.Empty, Square.Empty);

            var gameState = board.Evaluate();

            Assert.Equal(GameState.InProgress, gameState);
        }
    }
}
