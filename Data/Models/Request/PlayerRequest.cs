using System.ComponentModel.DataAnnotations;

namespace Data.Models.Request
{
    public class PlayerRequest
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int HeightIn { get; set; }

        [Required]
        public int Weight { get; set; }

        [Required]
        public int WingSpanIn { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string Architype { get; set; }

        [Required]
        public int CloseShot { get; set; }

        [Required]
        public int DrivingLayup { get; set; }

        [Required]
        public int DrivingDunk { get; set; }

        [Required]
        public int StandingDunk { get; set; }

        [Required]
        public int PostHook { get; set; }

        [Required]
        public int MidRangeShot { get; set; }

        [Required]
        public int ThreePointShot { get; set; }

        [Required]
        public int FreeThrow { get; set; }

        [Required]
        public int PostFade { get; set; }

        [Required]
        public int PassAccuracy { get; set; }

        [Required]
        public int BallHandle { get; set; }

        [Required]
        public int PostControl { get; set; }

        [Required]
        public int InteriorDefense { get; set; }

        [Required]
        public int PerimeterDefense { get; set; }

        [Required]
        public int LateralQuickness { get; set; }

        [Required]
        public int Steal { get; set; }

        [Required]
        public int Block { get; set; }

        [Required]
        public int OffensiveRebound { get; set; }

        [Required]
        public int DefensiveRebound { get; set; }

        [Required]
        public int Speed { get; set; }

        [Required]
        public int Acceleration { get; set; }

        [Required]
        public int Strength { get; set; }

        [Required]
        public int Vertical { get; set; }

        [Required]
        public int Stamina { get; set; }
    }
}
