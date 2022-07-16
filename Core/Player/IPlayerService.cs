using PlayerEF = Data.Entities.Player;

namespace Core.Player
{
    public interface IPlayerService
    {
        Task<IEnumerable<PlayerEF>> GetPlayersAsync();

    }
}
