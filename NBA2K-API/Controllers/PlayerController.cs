using Microsoft.AspNetCore.Mvc;
using Data.Models.Request;
//using Data.Models.Response;
using Data.Entities;
using Data.Repositories;

namespace NBA2K_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly ILogger<PlayerController> _logger;
        private readonly IPlayerRepository _playerRepository;

        public PlayerController(ILogger<PlayerController> logger, IPlayerRepository playerRepository)
        {
            _logger = logger;
            _playerRepository = playerRepository;
        }
        
        [HttpGet("/GetPlayers")]
        public async Task<ActionResult<List<Player>>> GetAllPlayers()
        {
            var result = await _playerRepository.GetPlayersAsync();           
            return Ok(result);
        }

        [HttpPost("/AddPlayer")]
        public async Task<bool> AddPlayerAsync([FromBody] PlayerRequest request)
        {
            if (!ModelState.IsValid)
            {
                return false;
            }

            var result = await _playerRepository.AddPlayerAsync(request);
            return result;
        }

        [HttpPut("/UpdatePlayer/{playerId}")]
        public async Task<bool> UpdatePlayerAsync(Guid playerId, [FromBody] UpdatePlayerRequest request)
        {
            if (!ModelState.IsValid)
            {
                return false;
            }

            var result = await _playerRepository.UpdatePlayerAsync(playerId, request);
            return result;
        }

        [HttpDelete("/DeletePlayer")]
        public async Task<bool> DeletePlayerAsync([FromBody] DeletePlayerRequest request)
        {
            if (!ModelState.IsValid)
            {
                return false;
            }

            var result = await _playerRepository.DeletePlayerAsync(request);
            return result;
        }
    }
}
