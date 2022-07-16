using Data.Entities;
using Data.Models.Request;
using Data.Models.Response;

namespace Data.Repositories
{
    public interface IPlayerRepository
    {
        Task<bool> UpdatePlayerAsync(Guid playerId, UpdatePlayerRequest request);

        Task<bool> DeletePlayerAsync(DeletePlayerRequest request);

        Task<bool> AddPlayerAsync(PlayerRequest request);

        Task<List<Player>> GetPlayersAsync();
    }
}
