namespace DATABASE_CL.classes
{
    public class BookPrice
    {
        public string BookPriceID { get; set; }
        public string BookTypeID { get; set; }
        public double Price { get; set; }

        public BookPrice()
        {
            this.BookPriceID = "";
            this.BookTypeID = "";
            this.Price = 0.0;
        }
        public BookPrice(string bookpriceid,string booktypeid,double price)
        {
            this.BookPriceID = bookpriceid;
            this.BookTypeID = booktypeid;
            this.Price = price;
        }
        ~BookPrice()
        {
            //DECONSTRUCT
        }
    }
}
