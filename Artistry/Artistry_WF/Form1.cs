using System;
using System.Windows.Forms;

namespace Artistry_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenderView gv = new GenderView();
            gv.ShowDialog();
        }
    }
}
