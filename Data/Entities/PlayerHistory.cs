using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class PlayerHistory : BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        public Guid PlayerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int HeightIn { get; set; }

        public int Weight { get; set; }

        public int WingSpanIn { get; set; }

        public string Position { get; set; }

        public string Architype { get; set; }

        public int CloseShot { get; set; }

        public int DrivingLayup { get; set; }

        public int DrivingDunk { get; set; }

        public int StandingDunk { get; set; }

        public int PostHook { get; set; }

        public int MidRangeShot { get; set; }

        public int ThreePointShot { get; set; }

        public int FreeThrow { get; set; }

        public int PostFade { get; set; }

        public int PassAccuracy { get; set; }

        public int BallHandle { get; set; }

        public int PostControl { get; set; }

        public int InteriorDefense { get; set; }

        public int PerimeterDefense { get; set; }

        public int LateralQuickness { get; set; }

        public int Steal { get; set; }

        public int Block { get; set; }

        public int OffensiveRebound { get; set; }

        public int DefensiveRebound { get; set; }

        public int Speed { get; set; }

        public int Acceleration { get; set; }

        public int Strength { get; set; }

        public int Vertical { get; set; }

        public int Stamina { get; set; }
    }
}
