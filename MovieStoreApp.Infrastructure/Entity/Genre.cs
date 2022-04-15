using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStoreApp.Infrastructure.Entity
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

