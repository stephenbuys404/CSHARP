using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOODB_CL.classfiles
{
    public class Zoo
    {
        #region Properties
        [Browsable(false)]
        public int ZooID { get; set; }
        [DisplayName("Zoo Name")]
        public string ZooName { get; set; }
        [DisplayName("Location of Zoo")]
        public string ZooLocation { get; set; }
        #endregion        
        #region Constructors
        public Zoo(){ZooID = 0;ZooName = "";ZooLocation = "";}
        public Zoo(int id, string name, string location){ZooID = id;ZooName = name;ZooLocation =location;}
        #endregion
    }
}
