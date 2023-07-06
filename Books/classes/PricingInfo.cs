using System;

namespace DATABASE_CL.classes
{
    public class PricingInfo
    {
        public string PricingID { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public PricingInfo()
        {
            this.PricingID = "";
            this.ISBN = "";
            this.Price = 0.0;
            this.StartDate = new DateTime();
            this.EndDate = new DateTime();
        }
        public PricingInfo(string pricingid,string isbn,double price,DateTime startdate,DateTime enddate)
        {
            this.PricingID = pricingid;
            this.ISBN = isbn;
            this.Price = price;
            this.StartDate = startdate;
            this.EndDate = enddate;
        }
        ~PricingInfo()
        {
            //DECONSTRUCT
        }
    }
}
