using System;
using System.Windows.Forms;

namespace MusicH_WF.forms.musictrackform
{
    public partial class MusicTrack : Form
    {
        private Musictracklist ml;
        public MusicTrack()
        {
            InitializeComponent();
            ml = new MusicTrack();
            dataGridView1.DataSource = ml.GetMusicTrack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusicTrack mt = new MusicTrack(0, "", 0);
            ml.Insert(mt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusicTrack mt = new MusicTrack(0, "", 0);
            ml.Delete(mt);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusicTrack mt = new MusicTrack(0, "", 0);
            ml.Update(mt);
        }
    }
}
