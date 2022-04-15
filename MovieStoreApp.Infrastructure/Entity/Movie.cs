using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStoreApp.Infrastructure.Entity 
{
    public class Movie {
        [Required]
        public int Id {get; set; }
        [MaxLength(256)]
        [Column(TypeName = "Varchar")]
        public string Title {get; set; }
        [MaxLength(1024)]
        [Column(TypeName = "Varchar")]
        public string Overview {get; set; }
        [MaxLength(128)]
        [Column(TypeName = "Varchar")]
        public string Tagline {get; set; }
        public decimal Budget {get; set; }
        public decimal Revenue {get; set; }
        [MaxLength(2048)]
        [Column(TypeName = "Varchar")]
        public string ImdbUrl {get; set; }
        [MaxLength(2048)]
        [Column(TypeName = "Varchar")]
        public string TmdbUrl {get; set; }
        [MaxLength(2048)]
        [Column(TypeName = "Varchar")]
        public string PosterUrl {get; set; }
        [MaxLength(2048)]
        [Column(TypeName = "Varchar")]
        public string BackdropUrl {get; set; }
        [MaxLength(64)]
        [Column(TypeName = "Varchar")]
        public string OriginalLanguage {get; set; }
        public DateTime ReleaseDate {get; set; }
        public int Runtime {get; set; }
        public decimal Price {get; set; }
        public DateTime CreatedDate {get; set; }
        public DateTime UpdatedDate {get; set; }
        [MaxLength(128)]
        [Column(TypeName = "Varchar")]
        public string CreatedBy {get; set; }
        [MaxLength(128)]
        [Column(TypeName = "Varchar")]
        public string UpdatedBy {get; set; }
        
    }
}

