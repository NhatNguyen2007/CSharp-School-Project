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
    public partial class AddToPlaylist_Playlist : UserControl
    {
        string SongName = "";
        string ArtistName = "";
        int id;
        public AddToPlaylist_Playlist(string songname, string artistname)
        {
            InitializeComponent();
            SongName = songname;
            ArtistName = artistname;
        }

        public Image getset_PlaylistPhoto
        {
            get
            {
                return ptr_PlaylistPhoto.Image;
            }
            set
            {
                ptr_PlaylistPhoto.Image = value;
            }
        }

        public string getset_PlaylistName
        {
            get
            {
                return lbl_PlaylistName.Text;
            }
            set
            {
                lbl_PlaylistName.Text = value;
            }
        }

        public string getset_PlaylistCount
        {
            get
            {
                return lbl_PlaylistCount.Text;
            }
            set
            {
                lbl_PlaylistCount.Text = value;
            }
        }

        private void btn_AddToPlaylist_Click(object sender, EventArgs e)
        {
            MainMenu.ListPlaylist[id].getset_SongName.Add(SongName);
            MainMenu.ListPlaylist[id].getset_ArtistName.Add(ArtistName);
            btn_AddToPlaylist.Text = "Added";
            btn_AddToPlaylist.Enabled = false;
            getset_PlaylistCount = MainMenu.ListPlaylist[id].getset_SongName.Count.ToString();
        }

        private void AddToPlaylist_Playlist_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < MainMenu.ListPlaylist.Count; i++)
            {
                if (getset_PlaylistName == MainMenu.ListPlaylist[i].getset_PlaylistName)
                {
                    for(int j=0; j< MainMenu.ListPlaylist[i].getset_SongName.Count; j++)
                    {
                        if(SongName == MainMenu.ListPlaylist[i].getset_SongName[j])
                        {
                            btn_AddToPlaylist.Text = "Added";
                            btn_AddToPlaylist.Enabled = false;
                            break;
                        }
                    }
                    id = i;
                    break;
                }
            }
        }
    }
}
