using Data.Entities;
using Data.Models.Request;
using Data.Models.Response;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly DbContextNBA2K _db;

        public PlayerRepository(DbContextNBA2K db)
        {
            _db = db;
        }

        public async Task<List<Player>> GetPlayersAsync()
        {
            var result = await _db.Player.ToListAsync();
            return result;
        }

        public async Task<bool> AddPlayerAsync(PlayerRequest request)
        {
            var player = new Player
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                HeightIn = request.HeightIn,
                Weight = request.Weight,
                WingSpanIn = request.WingSpanIn,
                Position = request.Position,
                Architype = request.Architype,
                CloseShot = request.CloseShot,
                DrivingLayup = request.DrivingLayup,
                StandingDunk = request.StandingDunk,
                PostHook = request.PostHook,
                MidRangeShot = request.MidRangeShot,
                ThreePointShot = request.ThreePointShot,
                FreeThrow = request.FreeThrow,
                PostFade = request.PostFade,
                PassAccuracy = request.PassAccuracy,
                BallHandle = request.BallHandle,
                PostControl = request.PostControl,
                InteriorDefense = request.InteriorDefense,
                PerimeterDefense = request.PerimeterDefense,
                LateralQuickness = request.LateralQuickness,
                Steal = request.Steal,
                Block = request.Block,
                OffensiveRebound = request.OffensiveRebound,
                DefensiveRebound = request.DefensiveRebound,
                Speed = request.Speed,
                Acceleration = request.Acceleration,
                Strength = request.Strength,
                Vertical = request.Vertical,
                Stamina = request.Stamina,
                Active = true,
                CreatedTime = DateTime.UtcNow,
            };

            var result = await _db.Player.AddAsync(player);

            return await _db.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeletePlayerAsync(DeletePlayerRequest request)
        {
            var player = await _db.Player.FindAsync(request.PlayerId);

            if(player == null)
            {
                return false;
            } else
            {
                // Add to history table
                var historyPlayer = new PlayerHistory
                {
                    PlayerId = player.PlayerId,
                    FirstName = player.FirstName,
                    LastName = player.LastName,
                    HeightIn = player.HeightIn,
                    Weight = player.Weight,
                    WingSpanIn = player.WingSpanIn,
                    Position = player.Position,
                    Architype = player.Architype,
                    CloseShot = player.CloseShot,
                    DrivingLayup = player.DrivingLayup,
                    StandingDunk = player.StandingDunk,
                    PostHook = player.PostHook,
                    MidRangeShot = player.MidRangeShot,
                    ThreePointShot = player.ThreePointShot,
                    FreeThrow = player.FreeThrow,
                    PostFade = player.PostFade,
                    PassAccuracy = player.PassAccuracy,
                    BallHandle = player.BallHandle,
                    PostControl = player.PostControl,
                    InteriorDefense = player.InteriorDefense,
                    PerimeterDefense = player.PerimeterDefense,
                    LateralQuickness = player.LateralQuickness,
                    Steal = player.Steal,
                    Block = player.Block,
                    OffensiveRebound = player.OffensiveRebound,
                    DefensiveRebound = player.DefensiveRebound,
                    Speed = player.Speed,
                    Acceleration = player.Acceleration,
                    Strength = player.Strength,
                    Vertical = player.Vertical,
                    Stamina = player.Stamina
                };

                // Save player to history table
                await _db.PlayerHistory!.AddAsync(historyPlayer);


                // Remove from Player table
                _db.Player.Remove(player);
            }

            return await _db.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdatePlayerAsync(Guid playerId, UpdatePlayerRequest request)
        {
            var player = await _db.Player.FirstOrDefaultAsync(x => x.PlayerId == playerId);
            
            if (player == null) { return false; }
            else
            {
                player.CloseShot = request.CloseShot;
                player.DrivingLayup = request.DrivingLayup;
                player.DrivingDunk = request.DrivingDunk;
                player.StandingDunk = request.StandingDunk;
                player.PostHook = request.PostHook;
                player.MidRangeShot = request.MidRangeShot;
                player.ThreePointShot = request.ThreePointShot;
                player.FreeThrow = request.FreeThrow;
                player.PostFade = request.PostFade;
                player.PassAccuracy = request.PassAccuracy;
                player.BallHandle = request.BallHandle;
                player.PostControl = request.PostControl;
                player.InteriorDefense = request.InteriorDefense;
                player.PerimeterDefense = request.PerimeterDefense;
                player.LateralQuickness = request.LateralQuickness;
                player.Steal = request.Steal;
                player.Block = request.Block;
                player.OffensiveRebound = request.OffensiveRebound;
                player.DefensiveRebound = request.DefensiveRebound;
                player.Speed = request.Speed;
                player.Acceleration = request.Acceleration;
                player.Strength = request.Strength;
                player.Vertical = request.Vertical;
                player.Stamina = request.Stamina;
                player.UpdatedTime = DateTime.UtcNow;

                _db.Player.Update(player);
            }

            return await _db.SaveChangesAsync() > 0;
        }
    }
}
