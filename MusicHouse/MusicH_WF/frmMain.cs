using System;
using System.Windows.Forms;

namespace MusicH_WF
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void aRTISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.artistform.Artist a = new forms.artistform.Artist();
            a.ShowDialog();
        }

        private void rANKINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.rankingform.Ranking r = new forms.rankingform.Ranking();
            r.ShowDialog();
        }

        private void aLBUMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.albumform.ALBUM a = new forms.albumform.ALBUM();
            a.ShowDialog();
        }

        private void mUSICTRACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.musictrackform.MusicTrack m = new forms.musictrackform.MusicTrack();
            m.ShowDialog();
        }
    }
}
