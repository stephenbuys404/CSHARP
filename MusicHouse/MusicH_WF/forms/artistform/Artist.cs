using System;
using System.Windows.Forms;

namespace MusicH_WF.forms.artistform
{
    public partial class Artist : Form
    {
        private Artistlist al;
        public Artist()
        {
            InitializeComponent();
            al = new Artistlist();
            dataGridView1.DataSource = al.GetArtistlist();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Artist aNew = new Classes.Artist(0, "", "", "", DateTime.Now, 0);
            al.InsertArtist(aNew);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Classes.Artist aNew = new Classes.Artist(0, "", "", "", DateTime.Now, 0);
            al.Delete(aNew);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Classes.Artist aNew = new Classes.Artist(0, "", "", "", DateTime.Now, 0);
            al.Update(aNew);
        }
    }
}
