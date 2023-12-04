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
    public partial class Home_SeeAll_YourPlaylists : Form
    {
        string playlistname = "";
        Image playlistphoto;
        public Home_SeeAll_YourPlaylists()
        {
            InitializeComponent();
        }

        private void btn_Back_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Back.BackgroundImage = Image.FromFile(@"..\\..\\IconImages\Back_MouseMove.png");
        }

        private void btn_Back_MouseLeave(object sender, EventArgs e)
        {
            btn_Back.BackgroundImage = Image.FromFile(@"..\\..\\IconImages\Back_MouseLeave.png");
        }

        private void Home_SeeAll_YourPlaylists_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < MainMenu.ListPlaylist.Count; i++)
            {
                playlistname = MainMenu.ListPlaylist[i].getset_PlaylistName;
                playlistphoto = MainMenu.ListPlaylist[i].getset_PlaylistPhoto;
                MusicBox x = new MusicBox();
                x.SongName = playlistname;
                x.SongImage = playlistphoto;
                x.setVisible();
                FlLayout_Container.Controls.Add(x);
            }
        }
        public void OpenChildForm(Form childForm, string FormName)
        {
            MainMenu newform = (MainMenu)this.Parent.Parent.Parent;

            if (MainMenu.currentChildForm != null)
            {
                MainMenu.currentChildForm.Close();
            }

            MainMenu.currentChildForm = childForm;

            MainMenu.currentForm = FormName;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            newform.pnl_Body.Controls.Add(childForm);
            newform.pnl_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home(), "Home");
        }
    }
}
