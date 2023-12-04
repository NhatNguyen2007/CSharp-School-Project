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
    public partial class Playlist_Interface : Form
    {
        string PlaylistName = "";
        string PlaylistDescrip = "";
        Image PlaylistPhoto;
        public int ID;
        public Playlist_Interface(string playlistname, string playlistdescrip, Image playlistphoto, int id)
        {
            InitializeComponent();
            PlaylistName = playlistname;
            PlaylistDescrip = playlistdescrip;
            PlaylistPhoto = playlistphoto;
            ID = id;
        }

        private void btn_Back_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Back.BackgroundImage = Image.FromFile(@"..\\..\\IconImages\Back_MouseMove.png");
        }

        private void btn_Back_MouseLeave(object sender, EventArgs e)
        {
            btn_Back.BackgroundImage = Image.FromFile(@"..\\..\\IconImages\Back_MouseLeave.png");
        }

        private void Playlist_Interface_Load(object sender, EventArgs e)
        {
            lbl_PlaylistName.Text = PlaylistName;
            lbl_PlaylistDescrip.Text = PlaylistDescrip;
            pnl_PlaylistPhoto.BackgroundImage = PlaylistPhoto;
            if(MainMenu.ListPlaylist[ID].getset_SongName.Count <= 1)
            {
                lbl_Count.Text = MainMenu.ListPlaylist[ID].getset_SongName.Count.ToString() + " song";
            }
            else
            {
                lbl_Count.Text = MainMenu.ListPlaylist[ID].getset_SongName.Count.ToString() + " songs";
            }
            
            for (int i=0; i<MainMenu.ListPlaylist[ID].getset_SongName.Count; i++)
            {
                Playlist_Song newsong = new Playlist_Song();
                newsong.getset_SongName = MainMenu.ListPlaylist[ID].getset_SongName[i];
                newsong.getset_ArtistName = MainMenu.ListPlaylist[ID].getset_ArtistName[i].Replace(" x ", ", ");
                newsong.getset_SongImage = Image.FromFile(@"..\\..\\SongImages\" + newsong.getset_SongName + ".jpg");
                FlLayout_PlaylistSong.Controls.Add(newsong);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if(MainMenu.currentForm == "Home")
            {
                OpenChildForm(new Home(), "Home");
            }
            else if(MainMenu.currentForm == "Search")
            {
                OpenChildForm(new Search(), "Search");
            }
            else if (MainMenu.currentForm == "YourLibrary")
            {
                OpenChildForm(new YourLibrary(), "YourLibrary");
            }
            else if (MainMenu.currentForm == "Home_SeeAll_RecentlyPlayed")
            {
                OpenChildForm(new Home_SeeAll_RecentlyPlayed(), "Home_SeeAll_RecentlyPlayed");
            }
            else if (MainMenu.currentForm == "Home_SeeAll_MadeForYou")
            {
                OpenChildForm(new Home_SeeAll_MadeForYou(), "Home_SeeAll_MadeForYou");
            }
            else if (MainMenu.currentForm == "Home_SeeAll_YourPlaylists")
            {
                OpenChildForm(new Home_SeeAll_YourPlaylists(), "Home_SeeAll_YourPlaylists");
            }
            else if (MainMenu.currentForm == "LikedSongs")
            {
                OpenChildForm(new LikedSongs(), "LikedSongs");
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

    }
}
