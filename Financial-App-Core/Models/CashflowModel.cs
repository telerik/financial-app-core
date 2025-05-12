using System.ComponentModel.DataAnnotations;

namespace Financial_App_Core.Models
{
    public class CashflowModel
    {
        [Key]
        public int Id { get; set; }


        public DateTime Date { get; set; }

        public string Month { get; set; }

        public int Stocks { get; set; }

        public int RealEstate { get; set; }

        public int Bonds { get; set; }
    }
}
