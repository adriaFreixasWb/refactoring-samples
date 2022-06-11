namespace Chess.Game.Domain
{
    public record EmptyPosition:Position
    {
        public EmptyPosition():base(string.Empty, 0)
        {
        }
    }
}
