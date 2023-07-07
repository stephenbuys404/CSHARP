namespace MUSICHOUSE_CL.Classes
{
    public class Album
    {
        public int AlbumID { get; set; }
        public Artist Artist { get; set; }
        public MusicTrack MusicTrack { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public Album()
        {
            AlbumID = 0;
            Artist = new Artist();
            MusicTrack = new MusicTrack();
            Price = 0;
            Stock = 0;
        }
        public Album(int ai,Artist a,MusicTrack mt,double p,int s)
        {
            AlbumID = ai;
            Artist = a;
            MusicTrack = mt;
            Price = p;
            Stock = s;
        }
        ~Album()
        {
            //DECONSTRUCT
        }
    }
}
