using System.ComponentModel.DataAnnotations;

namespace Financial_App_Core.Models
{
    public class TransactionModel
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public string Merchant { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public string PayMethod { get; set; }
        public TransactionStatus Status { get; set; }
        public string? Customer { get; set; }
        public string? Email { get; set; }
        public string? PaymentMethod { get; set; }
        public string? TransactionHash { get; set; }
    }

}
