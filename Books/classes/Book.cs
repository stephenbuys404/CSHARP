namespace DATABASE_CL.classes
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string AuthorID { get; set; }
        public string Publisher { get; set; }
        public string Edition { get; set; }

        public Book()
        {
            this.ISBN = "";
            this.Title = "";
            this.AuthorID = "";
            this.Publisher = "";
            this.Edition = "";
        }
        public Book(string isbn,string title,string authorid,string publisher,string edition)
        {
            this.ISBN = isbn;
            this.Title = title;
            this.AuthorID = authorid;
            this.Publisher = publisher;
            this.Edition = edition;
        }
        ~Book()
        {
            //DECONSTRUCT
        }
    }
}
