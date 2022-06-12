using Chess.Game.Domain;
using Chess.Game.Domain.Boards;
using System;

namespace Chess.Game.Test;

public static class PositionExtensions
{
    public static Position ToPosition(this string pos) =>
        new Position(Enum.Parse<Column>(
            pos.Substring(0, 1)),
            int.Parse(pos.Substring(1, 1)));
}
