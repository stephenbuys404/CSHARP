using System;

namespace DATABASE_CL.classes
{
    public class Author
    {
        public string AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public string Alias { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Author()
        {
            this.AuthorID = "";
            this.AuthorName = "";
            this.AuthorSurname = "";
            this.Alias = "";
            this.DateOfBirth = DateTime.Now;
        }
        public Author(string id,string name,string surname,string alias,DateTime dateofbirth)
        {
            this.AuthorID = id;
            this.AuthorName = name;
            this.AuthorSurname = surname;
            this.Alias = alias;
            this.DateOfBirth = dateofbirth;
        }
        ~Author()
        {
            //DECONSTRUCT
        }
    }
}
