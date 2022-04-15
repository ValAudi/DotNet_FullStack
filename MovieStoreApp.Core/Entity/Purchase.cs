namespace MovieStoreApp.Core.Entity 
{
    public class Purchase {
        public int PurchaseId { get; set; }
        public int UserId { get; set; }
        public Guid PurchaseNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime PurchaseDateTime { get; set; }
        public int MovieId { get; set; }
    }
}

