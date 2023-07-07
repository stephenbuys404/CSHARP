using System;
using System.Windows.Forms;

namespace MusicH_WF.forms.albumform
{
    public partial class ALBUM : Form
    {
        public ALBUM()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int AI;
            int A;
            int MT;
            int P;
            int S;
            albumService.UpdateAlbum(AI, A, MT, P, S);
            MessageBox.Show("Album updated.");
            albumService = new MusicHService.MusicHServiceClient();
            dataGridView1.DataSource = albumService.Album();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int AI;
            int A;
            int MT;
            int P;
            int S;
            albumService.DeleteAlbum(AI, A, MT, P, S);
            MessageBox.Show("Album deleted.");
            albumService = new MusicHService.MusicHServiceClient();
            dataGridView1.DataSource = albumService.Album();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int AI;
            int A;
            int MT;
            int P;
            int S;
            albumService.AddAlbum(AI, A, MT, P, S);
            MessageBox.Show("Album added.");
            albumService = new MusicHService.MusicHServiceClient();
            dataGridView1.DataSource = albumService.Album();
        }
    }
}
