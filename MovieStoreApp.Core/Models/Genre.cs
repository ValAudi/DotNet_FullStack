using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStoreApp.Core.Models
{
    public class Genre {
        [Required]
        public int GenreId { get; set; }
        [Required]
        [MaxLength(30)]
        [Column(TypeName = "Varchar")]
        public string GenreName { get; set; }
    }
}

