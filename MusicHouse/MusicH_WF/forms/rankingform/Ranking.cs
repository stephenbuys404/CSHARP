using System;
using System.Windows.Forms;

namespace MusicH_WF.forms.rankingform
{
    public partial class Ranking : Form
    {
        private Rankinglist rl;
        public Ranking()
        {
            InitializeComponent();
            rl = new Rankinglist();
            dataGridView1.DataSource = rl.GetRanking();
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            Ranking r = new Ranking(0, "");
            rl.Insert(r);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ranking r = new Ranking(0, "");
            rl.Delete(r);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ranking r = new Ranking(0, "");
            rl.Update(r);
        }
    }
}
