using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStoreApp.Core.Models 
{
    public class Purchase {
        [Required]
        public int PurchaseId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public Guid PurchaseNumber { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        [Required]
        public DateTime PurchaseDateTime { get; set; }
        [Required]
        public int MovieId { get; set; }
    }
}

