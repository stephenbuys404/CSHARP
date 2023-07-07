using System;
using System.ComponentModel;

namespace ZOODB_CL.classlistfiles
{
    public class GenderList : BindingList<classfiles.Gender>
    {
        private datafiles.ZooDSTableAdapters.GetGendersTableAdapter aGenderTableAdapter = new datafiles.ZooDSTableAdapters.GetGendersTableAdapter();
        private datafiles.ZooDS aZooDataSet = new datafiles.ZooDS();
        public GenderList()
        {
            aGenderTableAdapter.Fill(aZooDataSet.GetGenders, 0);
            foreach (datafiles.ZooDS.GetGendersRow aGenderRow in aZooDataSet.GetGenders.Rows)
            { classfiles.Gender aGender = new classfiles.Gender(aGenderRow.GenderID, aGenderRow.GenderName); this.Add(aGender); }
        }
        public GenderList(int id)
        {
            aGenderTableAdapter.Fill(aZooDataSet.GetGenders, id);
            foreach (datafiles.ZooDS.GetGendersRow aGenderRow in aZooDataSet.GetGenders.Rows) { if (aGenderRow.GenderID == id) { classfiles.Gender aGender = new classfiles.Gender(aGenderRow.GenderID, aGenderRow.GenderName); this.Add(aGender); } }
        }
        public void SaveGenderChanges()
        {
            datafiles.ZooDS.GetGendersDataTable aTempGenderTable = new datafiles.ZooDS.GetGendersDataTable(); try
            {
                foreach (classfiles.Gender aGender in this) { datafiles.ZooDS.GetGendersRow aNewGenderRow = aZooDataSet.GetGenders.NewGetGendersRow(); aNewGenderRow.GenderID = aGender.GenderID; aNewGenderRow.GenderName = aGender.GenderName; aTempGenderTable.Rows.Add(aNewGenderRow.ItemArray); } aZooDataSet.GetGenders.Merge(aTempGenderTable, false);
                foreach (datafiles.ZooDS.GetGendersRow aGenderRow in aZooDataSet.GetGenders.Rows) { if (aGenderRow.RowState == System.Data.DataRowState.Unchanged) { aGenderRow.Delete(); } } aGenderTableAdapter.Update(aZooDataSet.GetGenders);
            }
            catch (Exception ex) { Console.WriteLine("Error occurred when handling the gender table. "+ex.Message); }
        }
        public GenderList GetGender() { return this; }
        public GenderList GetGender(int id) { GenderList atempGenderList = new GenderList(id); return atempGenderList; }
        public void InsertGender(classfiles.Gender aGender) { this.Add(aGender); }
        public void DeleteGender(classfiles.Gender aDeleteGender) { int i = 0; int deleteIndex = -1; foreach (classfiles.Gender aGender in this) { if (aGender.GenderID == aDeleteGender.GenderID) { deleteIndex = i; } i++; } if (deleteIndex != -1) { this.RemoveAt(deleteIndex); } }
        public void UpdateGender(classfiles.Gender updateGender) { foreach (classfiles.Gender aGender in this) { if (aGender.GenderID == updateGender.GenderID) { aGender.GenderID = updateGender.GenderID; aGender.GenderName = updateGender.GenderName; break; } } }
    }
}