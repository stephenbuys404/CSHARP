namespace MUSICHOUSE_CL.Classes
{
    public class Ranking
    {
        public int RankID { get; set; }
        public string Description { get; set; }
        public Ranking()
        {
            RankID = 0;
            Description = "";
        }
        public Ranking(int id,string desc)
        {
            RankID = id;
            Description = desc;
        }
        ~Ranking()
        {
            //DECONSTRUCT
        }
    }
}
