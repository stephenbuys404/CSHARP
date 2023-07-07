using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOODB_CL.classfiles
{
    public class Species
    {
        #region Properties
        [Browsable(false)]
        public int SpeciesID { get; set; }
        [DisplayName("Species Description")]
        public string SpeciesName { get; set; }
        [DisplayName("Zoological Classficiation")]
        public string ZoologicalClass { get; set; }
        #endregion         
        #region Constructors 
        public Species()
        {SpeciesID = 0;SpeciesName = "";ZoologicalClass = "";}
        public Species(int id, string name, string zooclass){SpeciesID = id;SpeciesName = name;ZoologicalClass = zooclass;}
        #endregion
    }
}
