using System.ComponentModel;

namespace ZOODB_CL.classfiles
{
    public class Animal
    {
        #region Properties
        [Browsable(false)]
        public int AnimalID { get; set; }
        [DisplayName("Animal Name")]
        public string AnimalName { get; set; }
        [Browsable(false)]
        public int GenderID { get; set; }
        [Browsable(false)]
        public int SpeciesID { get; set; }

        [DisplayName("Gender Details")]
        public string GenderDescription { get; set; }
        [DisplayName("Species Details")]
        public string SpeciesDescription { get; set; }
#endregion
        #region Constructor
        public Animal()
        {
            AnimalID = 0;
            AnimalName = "";
            GenderID = 0;
            SpeciesID = 0;
            GenderDescription = "";
            SpeciesDescription = "";
        }

        public Animal(int id,string name,int genderid,int speciesid,string genderdescrip,string speciesdescrip)
        {
            AnimalID = id;
            AnimalName = name;
            GenderID = genderid;
            SpeciesID = speciesid;
            GenderDescription = genderdescrip;
            SpeciesDescription = speciesdescrip;
        }
        #endregion
    }
}
