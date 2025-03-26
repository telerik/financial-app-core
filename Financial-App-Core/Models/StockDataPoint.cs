using System.ComponentModel.DataAnnotations;

namespace Financial_App_Core.Models
{
    public class StockDataPoint
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public decimal Close { get; set; }
        public long Volume { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public string Symbol { get; set; }
    }
}
