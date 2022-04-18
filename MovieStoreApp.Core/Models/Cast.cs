using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStoreApp.Core.Models 
{
    public class Cast {
        [Required]
        public int Id {get; set; }
        [MaxLength(128)]
        [Column(TypeName = "Varchar")]
        public string Name {get; set; }
        public int Gender {get; set; }
        [MaxLength(2048)]
        [Column(TypeName = "Varchar")]
        public string TmdbUrl {get; set; }
        [MaxLength(2048)]
        [Column(TypeName = "Varchar")]
        public string ProfilePath {get; set; }
    }
}

