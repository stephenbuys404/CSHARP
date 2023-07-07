namespace MUSICHOUSE_CL.Classes
{
    public class MusicTrack
    {
        public int MusicTrackID { get; set; }
        public string TrackName { get; set; }
        public int TrackLength { get; set; }
        public MusicTrack()
        {
            MusicTrackID = 0;
            TrackName = "";
            TrackLength = 0;
        }
        public MusicTrack(int mti,string tn,int tl)
        {
            MusicTrackID = mti;
            TrackName = tn;
            TrackLength = tl;
        }
        ~MusicTrack()
        {
            //DECONSTRUCT
        }
    }
}
