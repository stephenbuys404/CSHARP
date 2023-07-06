using System;
using System.ComponentModel;

namespace DATABASE_CL.classlists
{
    public class AuthorCL:BindingList<classes.Author>
    {
        private datasets.BooksTut2DS aAuthorDataset = new datasets.BooksTut2DS();
        private datasets.BooksTut2DSTableAdapters.AuthorTableAdapter aAuthorAdapter = new datasets.BooksTut2DSTableAdapters.AuthorTableAdapter();
        public AuthorCL()
        {
            try
            {
                aAuthorAdapter.Fill(aAuthorDataset.Author);
                foreach (datasets.BooksTut2DS.AuthorRow aAuthorRow in aAuthorDataset.Author.Rows)
                {
                    classes.Author newAuthor = new classes.Author(aAuthorRow.AuthorID, aAuthorRow.AuthorName, aAuthorRow.AuthorSurname, aAuthorRow.AuthorAlias, aAuthorRow.DateOfBirth);
                    this.Add(newAuthor);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void Save()
        {
            datasets.BooksTut2DS.AuthorDataTable aTempAuthorTable = new datasets.BooksTut2DS.AuthorDataTable();
            foreach (classes.Author aAuthor in this)
            {
                datasets.BooksTut2DS.AuthorRow anAuthorRow = aAuthorDataset.Author.NewAuthorRow();
                anAuthorRow.AuthorID = aAuthor.AuthorID;
                anAuthorRow.AuthorName = aAuthor.AuthorName;
                anAuthorRow.AuthorSurname = aAuthor.AuthorSurname;
                anAuthorRow.AuthorAlias = aAuthor.Alias;
                anAuthorRow.DateOfBirth = aAuthor.DateOfBirth;
                aTempAuthorTable.Rows.Add(anAuthorRow.ItemArray);
            }
            aAuthorDataset.Author.Merge(aTempAuthorTable, false);
            foreach (datasets.BooksTut2DS.AuthorRow AuthorRow in aAuthorDataset.Author.Rows)
            {
                if(AuthorRow.RowState==System.Data.DataRowState.Unchanged)
                {
                    AuthorRow.Delete();
                }
            }
            aAuthorAdapter.Update(aAuthorDataset.Author);
        }

        public AuthorCL(string AuthorID)
        {
            aAuthorAdapter.Fill(aAuthorDataset.Author);
            foreach (datasets.BooksTut2DS.AuthorRow aAuthorRow in aAuthorDataset.Author.Rows)
            {
                if(AuthorID.Equals(aAuthorRow.AuthorID))
                {
                    classes.Author newAuthor = new classes.Author(aAuthorRow.AuthorID, aAuthorRow.AuthorName, aAuthorRow.AuthorSurname, aAuthorRow.AuthorAlias, aAuthorRow.DateOfBirth);
                    this.Add(newAuthor);
                }
            }
        }

        public AuthorCL GetAuthors()
        {
            return this;
        }
        public AuthorCL GetAuthors(string sAuthorID)
        {
            AuthorCL AuthorList = new AuthorCL(sAuthorID);
            return AuthorList;
        }

        public void InsertAuthor(classes.Author anAuthor)
        {
            this.Add(anAuthor);
        }

        public void DeleteAuthor(classes.Author anAuthor)
        {
            int i = 0;
            int deleteIndex = -1;
            foreach (classes.Author delAuthor in this)
            {
                if(delAuthor.AuthorID==anAuthor.AuthorID)
                {
                    deleteIndex = i;
                    this.RemoveAt(deleteIndex);
                }
                i++;
            }
        }

        public void UpdateAuthor(classes.Author anAuthor)
        {
            foreach (classes.Author updateAuthor in this)
            {
                if(updateAuthor.AuthorID==anAuthor.AuthorID)
                {
                    updateAuthor.AuthorID = anAuthor.AuthorID;
                    updateAuthor.AuthorName = anAuthor.AuthorName;
                    updateAuthor.AuthorSurname = anAuthor.AuthorSurname;
                    updateAuthor.Alias = anAuthor.Alias;
                    updateAuthor.DateOfBirth = anAuthor.DateOfBirth;
                    break;
                }
            }
        }
    }
}
