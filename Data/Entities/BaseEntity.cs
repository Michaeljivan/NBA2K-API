namespace Data.Entities
{
    public abstract class BaseEntity
    {
        public bool Active { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime UpdatedTime { get; set; }
    }
}
