using Chess.Game.Domain;
using Chess.Game.Domain.Boards;
using Chess.Game.Domain.Pieces;
using System;
using Xunit;

namespace Chess.Game.Test
{
    public class PiecesShould
    {
        [Theory]
        [InlineData("White", "E2", "D2")]
        [InlineData("White", "E2", "D3")]
        [InlineData("White", "E2", "E3")]
        [InlineData("White", "E2", "F3")]
        [InlineData("White", "E2", "F2")]
        [InlineData("White", "E2", "E1")]
        [InlineData("Black", "E7", "D7")]
        [InlineData("Black", "E7", "D6")]
        [InlineData("Black", "E7", "E6")]
        [InlineData("Black", "E7", "F6")]
        [InlineData("Black", "E7", "F7")]
        [InlineData("Black", "E7", "E8")]

        public void Move_On_Any_Direction_When_King(string color, string start, string end)
        {
            var piece = new Piece(PieceType.King, Enum.Parse<Color>(color), start.ToPosition());
            var endPos = end.ToPosition();
            var result = piece.Move(endPos);
            Assert.Equal(endPos, result.Position);
        }

        

    }
}
