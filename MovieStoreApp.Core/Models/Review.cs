using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStoreApp.Core.Models 
{
    public class Review {
        [Required]
        public int MovieId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public decimal Rating { get; set; }
        [MaxLength(1000)]
        [Column(TypeName = "Varchar")]
        public string ReviewText { get; set; }
        
    }
}

