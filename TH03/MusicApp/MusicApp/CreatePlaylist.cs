using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class CreatePlaylist : Form
    {
        string imgpath = "";
        public static bool flag = false;
        public CreatePlaylist()
        {
            InitializeComponent();
        }

        private void btn_Close_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Close.BackgroundImage = Image.FromFile(@"..\\..\\IconImages\BlackCross.png");
        }

        private void btn_Close_MouseLeave(object sender, EventArgs e)
        {
            btn_Close.BackgroundImage = Image.FromFile(@"..\\..\\IconImages\WhiteCross.png");
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            flag = false;
            this.DialogResult = DialogResult.OK;
        }

        private void CreatePlaylist_Load(object sender, EventArgs e)
        {
            txt_PlaylistName.Text = "My Playlist #" + (MainMenu.ListPlaylist.Count() + 1); ;
        }

        private void ptr_Playlist_MouseMove(object sender, MouseEventArgs e)
        {
            ptr_Playlist.Image = Image.FromFile(@"..\\..\\IconImages\ChoosePhoto.png");
        }

        private void ptr_Playlist_MouseLeave(object sender, EventArgs e)
        {
            if (imgpath == "")
            {
                ptr_Playlist.Image = Image.FromFile(@"..\\..\\IconImages\DefaultPhoto.png");
            }
            else
            {
                ptr_Playlist.Image = Image.FromFile(imgpath);
            }
        }

        private void ptr_Playlist_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imgpath = openFileDialog1.FileName;
                    ptr_Playlist.Image = Image.FromFile(imgpath);
                }
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            flag = true;
            Playlist playlist = new Playlist(txt_PlaylistName.Text, txt_PlaylistDescription.Text, ptr_Playlist.Image);
            MainMenu.ListPlaylist.Add(playlist);

            this.DialogResult = DialogResult.OK;
        }
    }
}
