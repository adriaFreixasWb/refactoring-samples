using Chess.Game.Domain;
using Chess.Game.Domain.Boards;
using Chess.Game.Domain.Pieces;
using System;
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

        [Theory]
        [InlineData("E1","D1")]
        [InlineData("E1", "D2")]
        [InlineData("E1", "E2")]
        [InlineData("E1", "F2")]
        [InlineData("E1", "F1")]

        public void Can_Move_King_Side_Ways(string start, string end)
        {
            var endPos = ToPosition(end);
            var piece = _board.Move(ToPosition(start), endPos);
            Assert.Equal(endPos, piece.Position);
        }

        private static Position ToPosition(string pos) =>
            new Position(Enum.Parse<Column>(
                pos.Substring(0, 1)), 
                int.Parse(pos.Substring(1, 1)));
    }
}