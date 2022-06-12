namespace Chess.Game.Domain.Pieces;

public record Pawn : Piece
{
    public Pawn(Color Color, Position Position) : base(PieceType.Pawn, Color, Position)
    {
    }
    public override Piece Move(Position pos)
    {
        if (!CanMove(pos))
        {
            return Empty;
        }
        return new Pawn(Color, pos);
    }

    private bool CanMove(Position pos)
    {
        if (Color == Color.White)
        {
            return Position.IsInFrontOf(pos) && Position.DeltaRow(pos.Row) == 1;
        }
        return Position.IsBehind(pos) && Position.DeltaRow(pos.Row) == -1;
    }
}
