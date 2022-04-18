using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStoreApp.Core.Models 
{
    public class MovieCast {
        [Required]
        public int MovieId { get; set; }
        [Required]
        public int CastId { get; set; }
        [Required]
        [MaxLength(128)]
        [Column(TypeName = "Varchar")]
        public string character {get; set; }
    }
}

 