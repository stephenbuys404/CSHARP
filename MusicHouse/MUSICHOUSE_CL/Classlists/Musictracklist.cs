using System.ComponentModel;

namespace MUSICHOUSE_CL.Classlists
{
    public class Musictracklist : BindingList<Classes.MusicTrack>
    {
        private Datafiles.MusicHTableAdapters.GetArtistTableAdapter aMusicTrackAdapter = new Datafiles.MusicHTableAdapters.GetArtistTableAdapter();
        private Datafiles.MusicH aMusicDS = new Datafiles.MusicH();
        public Musictracklist()
        {
            aMusicTrackAdapter.Fill(aMusicDS.GetArtist, 0);

            foreach (var item in aMusicDS.MusicTrack.Rows)
            {
                Classes.MusicTrack aMT = new Classes.MusicTrack();
                this.Add(aMT);
            }
        }

        public void SaveChanges()
        {
            Datafiles.MusicHTableAdapters.MusicTrackTableAdapter aTempTable = new Datafiles.MusicHTableAdapters.MusicTrackTableAdapter();

            foreach (Classes.MusicTrack aMT in this)
            {
                Datafiles.MusicH.MusicTrackRow aNewRow = new Datafiles.MusicH.MusicTrackRow(null);

                aNewRow.MusicTrackID = aMT.MusicTrackID;
                aNewRow.TrackName = aMT.TrackName;
                aNewRow.TrackLength = aMT.TrackLength;

                aTempTable.GetData().Rows.Add(aNewRow.ItemArray);
            }

            aMusicDS.MusicTrack.Merge(aTempTable.GetData(), false);

            foreach (Datafiles.MusicH.MusicTrackRow aMTRow in aMusicDS.MusicTrack.Rows)
            {
                if (aMTRow.RowState == System.Data.DataRowState.Unchanged)
                {
                    aMTRow.Delete();
                }
            }
        }

        public Musictracklist GetMusicTrack()
        {
            return this;
        }

        public void Insert(Classes.MusicTrack aNew)
        {
            this.Add(aNew);
        }

        public void Update(Classes.MusicTrack aUpdate)
        {
            foreach (Classes.MusicTrack aMT in this)
            {
                if (aMT.MusicTrackID == aUpdate.MusicTrackID)
                {
                    aMT.TrackName = aUpdate.TrackName;
                    aMT.TrackLength = aUpdate.TrackLength;
                    break;
                }
            }
        }

        public void Delete(Classes.MusicTrack aDelete)
        {
            int i = 0;
            int deleteIndex = -1;
            foreach (Classes.MusicTrack aMT in this)
            {
                if (aMT.MusicTrackID == aDelete.MusicTrackID)
                {
                    deleteIndex = i;
                }
                i++;
            }
            if (deleteIndex != -1)
            {
                this.RemoveAt(deleteIndex);
            }
        }
    }
}
