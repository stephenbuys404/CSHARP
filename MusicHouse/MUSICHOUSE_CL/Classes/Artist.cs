using System;

namespace MUSICHOUSE_CL.Classes
{
    public class Artist
    {
        public int ArtistID { get; set; }
        public string ArtistName { get; set; }
        public string ArtistSurname { get; set; }
        public string ArtistStageName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Ranking Ranking { get; set; }
        public Artist()
        {
            ArtistID = 0;
            ArtistName = "";
            ArtistSurname = "";
            ArtistStageName = "";
            DateOfBirth = DateTime.Now;
            Ranking = new Ranking();
        }
        public Artist(int id,string an,string a,string asn,DateTime dob,Ranking rank)
        {
            ArtistID = id;
            ArtistName = an;
            ArtistSurname = a;
            ArtistStageName = asn;
            DateOfBirth = dob;
            Ranking = rank;
        }
        ~Artist()
        {
            //DECONSTRUCT
        }
    }
}
