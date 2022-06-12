namespace Chess.Game.Domain.Pieces;

public record EmptyPiece : Piece
{
    public EmptyPiece() : base(PieceType.None, Color.None, new EmptyPosition())
    {
    }
}
