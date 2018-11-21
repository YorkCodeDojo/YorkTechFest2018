using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OsAndXs.Tests
{
    public class TheGameIsInvalid
    {
        [Fact]
        public void GivenTooManyMovesForOs()
        {
            var board = new Board(Square.X, Square.X, Square.O,
                                  Square.O, Square.O, Square.O,
                                  Square.X, Square.O, Square.Empty);

            var gameState = board.Evaluate();

            Assert.Equal(GameState.Invalid, gameState);
        }

        [Fact]
        public void GivenTooManyMovesForXs()
        {
            var board = new Board(Square.X, Square.X, Square.X,
                                  Square.O, Square.X, Square.O,
                                  Square.X, Square.X, Square.Empty);

            var gameState = board.Evaluate();

            Assert.Equal(GameState.Invalid, gameState);
        }

        [Fact]
        public void GivenAWinForOsAndXs()
        {
            var board = new Board(Square.X, Square.O, Square.X,
                                  Square.X, Square.O, Square.O,
                                  Square.X, Square.O, Square.Empty);

            var gameState = board.Evaluate();

            Assert.Equal(GameState.Invalid, gameState);
        }

    }
}
