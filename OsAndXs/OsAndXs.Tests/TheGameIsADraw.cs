using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OsAndXs.Tests
{
    public class TheGameIsADraw
    {
        [Fact]
        public void GivenAFullBoard()
        {
            var board = new Board(Square.X, Square.X, Square.O,
                                  Square.O, Square.O, Square.X,
                                  Square.X, Square.O, Square.X);

            var gameState = board.Evaluate();

            Assert.Equal(GameState.Draw, gameState);
        }
    }
}
