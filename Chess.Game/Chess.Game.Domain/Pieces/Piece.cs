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
        if(Type == PieceType.King)
        {
            var (deltaRow, deltaCol) = (
                Math.Abs(Position.DeltaRow(pos.Row)),
                Math.Abs(Position.DeltaColumn(pos.Column)));
            return Math.Max(deltaRow, deltaCol) == 1;
        }
        return false;
    }

    public bool IsAt(Position position) =>
        Position.Equals(position);
}
