using Data.Repositories;
using PlayerEF = Data.Entities.Player;

namespace Core.Player
{
    public class PlayerService
    {
        private readonly IPlayerRepository _playerRepository;
        
        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task<IEnumerable<PlayerEF>> GetPlayersAsync()
        {
            return await _playerRepository.GetPlayersAsync();
        }

    }
}
