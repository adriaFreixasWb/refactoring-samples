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
            Assert.Null(_board.Move(new Position("B",4), new Position("B",5)));
        }

        [Fact]
        public void Move_Piece()
        {
            var endPos = new Position("A", 3);
            var piece = _board.Move(new Position("A", 2), endPos);
            Assert.Equal(endPos, piece.Position);
        }
    }
}