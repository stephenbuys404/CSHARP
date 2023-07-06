namespace Artistry_Service
{
    public class ArtistryService : IArtistryService
    {
        private Artistry_CL.classlistfiles.GenderList GL = new Artistry_CL.classlistfiles.GenderList();
        public Artistry_CL.classlistfiles.GenderList GetGenderInfo() { return GL; }
        public void AddGender(string genderDescription)
        {
            Artistry_CL.classes.Gender aGender = new Artistry_CL.classes.Gender();
            aGender.Description = genderDescription;
            GL.InsertGender(aGender);
            GL.SaveGenderChanges();
        }
        public void UpdateGender(int id, string description)
        { 
            Artistry_CL.classes.Gender updateGender = new Artistry_CL.classes.Gender(id, description);
            GL.UpdateGender(updateGender);
            GL.SaveGenderChanges();
        }
        public void DeleteGender(int id, string description)
        {
            Artistry_CL.classes.Gender deleteGender = new Artistry_CL.classes.Gender(id, description);
            GL.DeleteGender(deleteGender);
            GL.SaveGenderChanges();
        }
    }
}
