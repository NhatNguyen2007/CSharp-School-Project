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
    public partial class AddToPlaylist_Interface : Form
    {
        string SongName = "";
        string ArtistName = "";
        public AddToPlaylist_Interface(string songname, string artistname)
        {
            InitializeComponent();
            SongName = songname;
            ArtistName = artistname;
        }

        private void AddToPlaylist_Interface_Load(object sender, EventArgs e)
        {
            for(int i=0; i<MainMenu.ListPlaylist.Count; i++)
            {
                AddToPlaylist_Playlist playlist = new AddToPlaylist_Playlist(SongName, ArtistName);
                playlist.getset_PlaylistName = MainMenu.ListPlaylist[i].getset_PlaylistName;
                playlist.getset_PlaylistPhoto = MainMenu.ListPlaylist[i].getset_PlaylistPhoto;
                playlist.getset_PlaylistCount = MainMenu.ListPlaylist[i].getset_SongName.Count.ToString();
                FlLayout_Playlist.Controls.Add(playlist);
            }
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
            this.DialogResult = DialogResult.OK;
        }
    }
}
