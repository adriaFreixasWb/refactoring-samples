using Chess.Game.Domain;
using Xunit;

namespace Chess.Game.Test
{
    public class BoardShould
    {
        private readonly Board _board;

        public BoardShould()
        {
            _board = new Board();
        }

        [Fact]
        public void No_Move_When_Square_Empty()
        {
            Assert.Null(_board.Move("B",4,"B",5)) ;
        }

        [Fact]
        public void Move_Piece()
        {
            var (endColumn, endRow) = ("A", 3);
            var piece = _board.Move("A", 2, endColumn, endRow);
            Assert.Equal(endColumn, piece.Column);
            Assert.Equal(endRow, piece.Row);
        }
    }
}