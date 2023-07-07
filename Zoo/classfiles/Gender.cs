using System.ComponentModel;

namespace ZOODB_CL.classfiles
{
    public class Gender
    {
        #region Properties
        [Browsable(false)]
        public int GenderID { get; set; }
        [DisplayName("Gender Description")]
        public string GenderName { get; set; }
        #endregion
        #region Constructors
        public Gender()
        { GenderID = 0; GenderName = ""; }
        public Gender(int id, string name) { GenderID = id; GenderName = name; }
        #endregion
    }
}
