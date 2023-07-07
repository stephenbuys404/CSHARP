using MUSICHOUSE_CL.Classes;
using System;
using System.ComponentModel;
using System.Data;

namespace MUSICHOUSE_CL.Classlists
{
    public class Albumlist : BindingList<Classes.Album>
    {
        private Datafiles.MusicHTableAdapters.GetArtistTableAdapter aAlbumAdapter = new Datafiles.MusicHTableAdapters.GetArtistTableAdapter();
        private Datafiles.MusicH aMusicDS = new Datafiles.MusicH();
        public Albumlist()
        {
            aAlbumAdapter.Fill(aMusicDS.GetArtist, 0);

            foreach (var item in aMusicDS.GetArtist.Rows)
            {
                Classes.Album aAlbum = new Classes.Album();
                this.Add(aAlbum);
            }
        }

        public void SaveGenderChanges()
        {
            Datafiles.MusicHTableAdapters.AlbumTableAdapter aTempTable = new Datafiles.MusicHTableAdapters.AlbumTableAdapter();

            foreach (Album aAlbum in this)
            {
                Datafiles.MusicH.AlbumRow aNewRow = new Datafiles.MusicH.AlbumRow(null);

                aNewRow.AlbumID = aAlbum.AlbumID;
                aNewRow.Artist = aAlbum.Artist.ArtistID;
                aNewRow.MusicTrack = aAlbum.MusicTrack.MusicTrackID;
                aNewRow.Price = Convert.ToInt32(aAlbum.Price);
                aNewRow.Stock = aAlbum.Stock;

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

        public Albumlist GetAlbums()
        {
            return this;
        }

        public void InsertAlbum(Album aNew)
        {
            this.Add(aNew);
        }

        public void UpdateGender(Album aUpdate)
        {
            foreach (Album aAlbum in this)
            {
                if (aAlbum.AlbumID == aUpdate.AlbumID)
                {
                    aAlbum.Artist = aUpdate.Artist;
                    aAlbum.MusicTrack = aUpdate.MusicTrack;
                    aAlbum.Price = aUpdate.Price;
                    aAlbum.Stock = aUpdate.Stock;
                    break;
                }
            }
        }

        public void DeleteAlbum(Album aDelete)
        {
            int i = 0;
            int deleteIndex = -1;
            foreach (Album aAlbum in this)
            {
                if (aAlbum.AlbumID == aDelete.AlbumID)
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
