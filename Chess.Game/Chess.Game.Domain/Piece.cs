namespace Chess.Game.Domain
{
    public record Piece(string Type, string Color, string Column, int Row)
    {
        public Piece Move(string column, int row)
        {
            return new Piece(Type, Color, column, row);
        }
    }
}
