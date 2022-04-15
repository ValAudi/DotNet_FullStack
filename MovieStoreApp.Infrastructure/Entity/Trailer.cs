using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStoreApp.Infrastructure.Entity 
{
    public class Trailer {
        [Required]
        public int TrailerId { get; set; }
        [Required]
        public int MovieId { get; set; }
        [MaxLength(128)]
        [Column(TypeName = "Varchar")]
        public string TrailerUrl { get; set; }
        [MaxLength(128)]
        [Column(TypeName = "Varchar")]
        public string TrailerName { get; set; }
    }
}
