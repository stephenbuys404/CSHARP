using System.ComponentModel;

namespace MUSICHOUSE_CL.Classlists
{
    public class Rankinglist : BindingList<Classes.Ranking>
    {
        private Datafiles.MusicHTableAdapters.GetArtistTableAdapter aRankingAdapter = new Datafiles.MusicHTableAdapters.GetArtistTableAdapter();
        private Datafiles.MusicH aMusicDS = new Datafiles.MusicH();
        public Rankinglist()
        {
            aRankingAdapter.Fill(aMusicDS.GetArtist, 0);

            foreach (var item in aMusicDS.GetArtist.Rows)
            {
                Classes.Ranking aRank = new Classes.Ranking();
                this.Add(aRank);
            }
        }

        public void SaveChanges()
        {
            Datafiles.MusicHTableAdapters.RankingTableAdapter aTempTable = new Datafiles.MusicHTableAdapters.RankingTableAdapter();

            foreach (Classes.Ranking aRank in this)
            {
                Datafiles.MusicH.RankingRow aNewRow = new Datafiles.MusicH.RankingRow(null);

                aNewRow.RankID = aRank.RankID;
                aNewRow.Description = aRank.Description;

                aTempTable.GetData().Rows.Add(aNewRow.ItemArray);
            }

            aMusicDS.Album.Merge(aTempTable.GetData(), false);

            foreach (Datafiles.MusicH.AlbumRow aAlbumRow in aMusicDS.Album.Rows)
            {
                if (aAlbumRow.RowState == System.Data.DataRowState.Unchanged)
                {
                    aAlbumRow.Delete();
                }
            }
        }

        public Rankinglist GetRanking()
        {
            return this;
        }

        public void InsertAlbum(Classes.Ranking aNew)
        {
            this.Add(aNew);
        }

        public void Update(Classes.Ranking aUpdate)
        {
            foreach (Classes.Ranking aRank in this)
            {
                if (aRank.RankID == aUpdate.RankID)
                {
                    aRank.Description = aUpdate.Description;
                    break;
                }
            }
        }

        public void Delete(Classes.Ranking aDelete)
        {
            int i = 0;
            int deleteIndex = -1;
            foreach (Classes.Ranking aRank in this)
            {
                if (aRank.RankID == aDelete.RankID)
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
