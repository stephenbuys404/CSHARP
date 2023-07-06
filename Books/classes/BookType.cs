namespace DATABASE_CL.classes
{
    public class BookType
    {
        public string BookTypeID { get; set; }
        public string BookType_Name { get; set; }

        public BookType()
        {
            this.BookTypeID = "";
            this.BookType_Name = "";
        }
        public BookType(string booktypeid,string booktypename)
        {
            this.BookTypeID = booktypeid;
            this.BookType_Name = booktypename;
        }
        ~BookType()
        {
            //DECONSTRUCT
        }
    }
}
