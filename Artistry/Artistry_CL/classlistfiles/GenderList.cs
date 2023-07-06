using System;
using System.ComponentModel;

namespace Artistry_CL.classlistfiles
{
    public class GenderList:BindingList<classes.Gender>
    {
        private datafiles.ArtistryDSTableAdapters.sp_Gender_SelectTableAdapter aGenderAdapter = new datafiles.ArtistryDSTableAdapters.sp_Gender_SelectTableAdapter();
        private datafiles.ArtistryDS aArtistryDS = new datafiles.ArtistryDS();
        public GenderList()
        {
            try
            {
                aGenderAdapter.Fill(aArtistryDS.sp_Gender_Select, 0);
                foreach (datafiles.ArtistryDS.sp_Gender_SelectRow aGenderRow in aArtistryDS.sp_Gender_Select.Rows)
                { classes.Gender aGender = new classes.Gender(aGenderRow.GenderID, aGenderRow.GenderName); this.Add(aGender); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public GenderList(int id)
        {
            try
            {
                aGenderAdapter.Fill(aArtistryDS.sp_Gender_Select, id);
                foreach (datafiles.ArtistryDS.sp_Gender_SelectRow aGenderRow in aArtistryDS.sp_Gender_Select.Rows) { if (aGenderRow.GenderID == id) { classes.Gender aGender = new classes.Gender(aGenderRow.GenderID, aGenderRow.GenderName); this.Add(aGender); } }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void SaveGenderChanges()
        {
            try
            {
                datafiles.ArtistryDS.sp_Gender_SelectDataTable aTempGenderTable = new datafiles.ArtistryDS.sp_Gender_SelectDataTable();
                foreach (classes.Gender aGender in this)
                {
                    datafiles.ArtistryDS.sp_Gender_SelectRow aNewGenderRow = aArtistryDS.sp_Gender_Select.Newsp_Gender_SelectRow(); aNewGenderRow.GenderID = aGender.GenderID; aNewGenderRow.GenderName = aGender.Description; aTempGenderTable.Rows.Add(aNewGenderRow.ItemArray);
                } 
                aArtistryDS.sp_Gender_Select.Merge(aTempGenderTable, false);
                foreach (datafiles.ArtistryDS.sp_Gender_SelectRow aGenderRow in aArtistryDS.sp_Gender_Select.Rows) { if (aGenderRow.RowState == System.Data.DataRowState.Unchanged) { aGenderRow.Delete(); } } aGenderAdapter.Update(aArtistryDS.sp_Gender_Select);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public GenderList GetGenders() { return this; }
        public GenderList GetGender(int id)
        {
            classlistfiles.GenderList tempList = new GenderList(id);
            return tempList;
        }
        public void InsertGender(classes.Gender aNewGender) { this.Add(aNewGender); }
        public void UpdateGender(classes.Gender aUpdateGender) { foreach (classes.Gender aGender in this) { if (aGender.GenderID == aUpdateGender.GenderID) { aGender.Description = aUpdateGender.Description; break; } } }
        public void DeleteGender(classes.Gender aDeleteGender)
        {
            try
            {
                int i = 0; int deleteIndex = -1;
                foreach (classes.Gender aGender in this) { if (aGender.GenderID == aDeleteGender.GenderID) { deleteIndex = i; } i++; } if (deleteIndex != -1) { this.RemoveAt(deleteIndex); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}