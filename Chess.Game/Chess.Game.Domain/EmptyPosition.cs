using Chess.Game.Domain.Boards;
namespace Chess.Game.Domain;

public record EmptyPosition:Position
{
    public EmptyPosition():base(Column.None, 0)
    {
    }
}
