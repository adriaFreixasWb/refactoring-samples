namespace Chess.Game.Domain.Pieces;

public record Piece(PieceType Type, Color Color, Position Position)
{
    public static EmptyPiece Empty { get; } = new EmptyPiece();
    public Piece Move(Position pos)
    {
        if (!CanMove(pos))
        {
            return Empty;
        }
        return new Piece(Type, Color, pos);
    }

    private bool CanMove(Position pos)
    {
        if(Type == PieceType.Pawn)
        {
            if(Color == Color.White)
            {
                return Position.IsInFrontOf(pos) && Position.DeltaRow(pos.Row) == 1;
            }
            else
            {
                return Position.IsBehind(pos) && Position.DeltaRow(pos.Row) == -1; 
            }
        }
        return false;
    }

    public bool IsAt(Position position) =>
        Position.Equals(position);
}
