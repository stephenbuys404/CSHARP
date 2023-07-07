namespace Artistry_CL.classes
{
    public class Gender
    {
        public int GenderID { get; set; }
        public string Description { get; set; }
        public Gender() { this.GenderID = 0; this.Description = ""; }
        public Gender(int id, string description) { this.GenderID = id; this.Description = description; }
	~Gender() {//DECONSTRUCT}
    }
}
