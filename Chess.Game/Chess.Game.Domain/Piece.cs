namespace Chess.Game.Domain;

public record Piece(string Type, string Color, Position Position)
{
    public Piece Move(Position pos)
    {
        return new Piece(Type, Color, pos);
    }

    public bool IsAt(Position position) =>
        Position.Equals(position);
}
