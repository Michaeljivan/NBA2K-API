using System.ComponentModel.DataAnnotations;

namespace Data.Models.Request
{
    public class DeletePlayerRequest
    {
        [Required]
        public Guid PlayerId { get; set; }
    }
}
