using Chess.Game.Domain.Pieces;
using System;
using Xunit;

namespace Chess.Game.Test;

public class PawnShould
{
    [Theory]
    [InlineData("White", "A2", "B2")]
    [InlineData("White", "B2", "A2")]
    [InlineData("Black", "A2", "B2")]
    [InlineData("Black", "B2", "A2")]
    public void Not_Move_Side_Ways(string color, string start, string end)
    {
        var piece = new Pawn(Enum.Parse<Color>(color), start.ToPosition());
        Assert.Equal(Piece.Empty, piece.Move(end.ToPosition()));
    }

    [Theory]
    [InlineData("White", "A2", "A3")]
    [InlineData("White", "H2", "H3")]
    [InlineData("Black", "A7", "A6")]
    [InlineData("Black", "B7", "B6")]
    public void Not_Move_Side_Forward(string color, string start, string end)
    {
        var piece = new Pawn(Enum.Parse<Color>(color), start.ToPosition());
        var endPos = end.ToPosition();
        var moved = piece.Move(endPos);
        Assert.Equal(endPos, moved.Position);
    }
}
