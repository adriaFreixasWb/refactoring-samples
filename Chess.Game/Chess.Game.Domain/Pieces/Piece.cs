namespace Chess.Game.Domain.Pieces;

public record Piece(string Type, Colors Color, Position Position)
{
    public const string PAWN = "Pawn";

    public Piece Move(Position pos)
    {
        return new Piece(Type, Color, pos);
    }

    public bool IsAt(Position position) =>
        Position.Equals(position);
}
