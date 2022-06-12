namespace Chess.Game.Domain.Pieces;

public record Piece(PieceType Type, Color Color, Position Position)
{
    public Piece Move(Position pos)
    {
        return new Piece(Type, Color, pos);
    }

    public bool IsAt(Position position) =>
        Position.Equals(position);
}
