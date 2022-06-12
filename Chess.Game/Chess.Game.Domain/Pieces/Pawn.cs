namespace Chess.Game.Domain.Pieces;

public record Pawn : Piece
{
    public Pawn(Color Color, Position Position) : base(PieceType.Pawn, Color, Position)
    {
    }
}
