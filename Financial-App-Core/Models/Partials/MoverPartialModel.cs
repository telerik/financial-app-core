namespace Financial_App_Core.Models
{
    public class MoverPartialModel
    {
        public string ImageUrl
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Abbreviation
        {
            get;
            set;
        }

        public TrendModel Q1
        {
            get;
            set;
        }

        public TrendModel Q2
        {
            get;
            set;
        }

        public decimal TotalEarnings
        {
            get;
            set;
        }
    }

    public class TrendModel
    {
        public decimal Earning { get; set; }
        public bool IsNegative { get; set; }
        public double Difference { get; set; }
        public int Percent { get; set; }
    }
}
