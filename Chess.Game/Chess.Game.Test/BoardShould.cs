using Chess.Game.Domain;
using Chess.Game.Domain.Boards;
using Chess.Game.Domain.Pieces;
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
            Assert.Equal(new EmptyPiece(), _board.Move(new Position(Column.B,4), new Position(Column.B,5)));
        }

        [Fact]
        public void Move_Piece()
        {
            var endPos = new Position(Column.A, 3);
            var piece = _board.Move(new Position(Column.A, 2), endPos);
            Assert.Equal(endPos, piece.Position);
        }

        [Fact]
        public void Can_Move_Pawn_Side_Ways()
        {
            Assert.Equal(new EmptyPiece(), _board.Move(new Position(Column.A, 2), new Position(Column.B, 2)));
        }
    }
}