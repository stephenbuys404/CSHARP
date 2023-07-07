using System.ComponentModel;

namespace MUSICHOUSE_CL.Classlists
{
    public class Artistlist : BindingList<Classes.Artist>
    {
        private Datafiles.MusicHTableAdapters.GetArtistTableAdapter aArtistAdapter = new Datafiles.MusicHTableAdapters.GetArtistTableAdapter();
        private Datafiles.MusicH aMusicDS = new Datafiles.MusicH();

        public Artistlist()
        {
            aArtistAdapter.Fill(aMusicDS.GetArtist, 0);

            foreach (var item in aMusicDS.GetArtist.Rows)
            {
                Classes.Artist aArtist = new Classes.Artist();
                this.Add(aArtist);
            }
        }

        public void SaveChanges()
        {
            Datafiles.MusicHTableAdapters.GetArtistTableAdapter aTempTable = new Datafiles.MusicHTableAdapters.GetArtistTableAdapter();

            foreach (Classes.Artist aArtist in this)
            {
                Datafiles.MusicH.GetArtistRow aNewRow = new Datafiles.MusicH.GetArtistRow(null);

                aNewRow.ArtistID = aArtist.ArtistID;
                aNewRow.ArtistName = aArtist.ArtistName;
                aNewRow.ArtistSurname = aArtist.ArtistSurname;
                aNewRow.ArtistStageName = aArtist.ArtistStageName;
                aNewRow.DateOfBirth = aArtist.DateOfBirth;
                aNewRow.Ranking = aArtist.Ranking.RankID;

                aTempTable.GetData(0).Rows.Add(aNewRow.ItemArray);
            }

            aMusicDS.GetArtist.Merge(aTempTable.GetData(0), false);

            foreach (Datafiles.MusicH.GetArtistRow aArtistRow in aMusicDS.GetArtist.Rows)
            {
                if (aArtistRow.RowState == System.Data.DataRowState.Unchanged)
                {
                    aArtistRow.Delete();
                }
            }
        }

        public Artistlist GetArtistlist()
        {
            return this;
        }

        public void InsertArtist(Classes.Artist aNew)
        {
            this.Add(aNew);
        }

        public void Update(Classes.Artist aUpdate)
        {
            foreach (Classes.Artist aArtist in this)
            {
                if (aArtist.ArtistID == aUpdate.ArtistID)
                {
                    aArtist.ArtistName = aUpdate.ArtistName;
                    aArtist.ArtistSurname = aUpdate.ArtistSurname;
                    aArtist.ArtistStageName = aUpdate.ArtistStageName;
                    aArtist.DateOfBirth = aUpdate.DateOfBirth;
                    aArtist.Ranking = aUpdate.Ranking;
                    break;
                }
            }
        }

        public void Delete(Classes.Artist aDelete)
        {
            int i = 0;
            int deleteIndex = -1;
            foreach (Classes.Artist aArtist in this)
            {
                if (aArtist.ArtistID == aDelete.ArtistID)
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
