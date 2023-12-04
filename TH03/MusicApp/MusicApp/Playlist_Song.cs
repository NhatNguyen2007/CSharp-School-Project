using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Xml;

namespace MusicApp
{
    public partial class Playlist_Song : UserControl
    {
        string songname = "";

        int like = 0;

        XmlDocument xmlDoc = new XmlDocument();
        public Playlist_Song()
        {
            InitializeComponent();
        }

        public Image getset_SongImage
        {
            get
            {
                return ptr_SongImg.Image;
            }
            set
            {
                ptr_SongImg.Image = value;
            }
        }

        public string getset_SongName
        {
            get
            {
                return lbl_SongName.Text;
            }
            set
            {
                lbl_SongName.Text = value;
            }
        }

        public string getset_ArtistName
        {
            get
            {
                return lbl_ArtistName.Text;
            }
            set
            {
                lbl_ArtistName.Text = value;
            }
        }

        public string getset_Duration
        {
            get
            {
                return lbl_Duration.Text;
            }
            set
            {
                lbl_Duration.Text = value;
            }
        }

        private void lbl_SongName_Click(object sender, EventArgs e)
        {
            PlayMusic();
        }

        private void Playlist_Song_Load(object sender, EventArgs e)
        {
            songname = getset_SongName;
            WindowsMediaPlayerClass wmp = new WindowsMediaPlayerClass();
            IWMPMedia mediaInformation = wmp.newMedia(@"D:\\NhatNguyen\\HK1 - Nam_3\\Ngôn Ngữ Lập Trình C#\\Practice\\TH03\\MP3\\" + songname + ".mp3");
            getset_Duration = mediaInformation.durationString.ToString();
            if (getset_SongName.Length > 32)
            { 
                getset_SongName = getset_SongName.Substring(0, 33) + "...";
            }

            if(MainMenu.currentForm== "LikedSongs")
            {
                rjDropDownMenu1.Items[0].Visible = false;
            }
        }

        private void Playlist_Song_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.FromArgb(42, 42, 42);
        }

        private void Playlist_Song_Leave(object sender, EventArgs e)
        {
        }

        private void Playlist_Song_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        private void ptr_SongImg_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.FromArgb(42, 42, 42);
        }

        private void ptr_SongImg_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        private void lbl_SongName_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.FromArgb(42, 42, 42);
        }

        private void lbl_SongName_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        private void lbl_ArtistName_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.FromArgb(42, 42, 42);
        }

        private void lbl_ArtistName_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        public void PlayMusic()
        {
            MainMenu.currentSong = this.songname;
            xmlDoc.Load(@"..\\..\\XML\Songs.xml");

            foreach (XmlNode node in xmlDoc.SelectNodes("/Songs" + "/Song"))
            {
                string Name = node.SelectSingleNode("Name").InnerText.Trim();
                if (Name == this.songname)
                {
                    XmlNode likeNode = node.SelectSingleNode("Like");
                    this.like = Convert.ToInt32(likeNode.InnerText.Trim());
                    break;
                }
            }

            if (MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs.Contains(this.songname) == true)
            {
                int x = MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs.IndexOf(this.songname);
                MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs.RemoveAt(x);
                MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs.Insert(0, this.songname);
                MainMenu.ListeningRecord.GlobalRecentlyPlayedArtist.RemoveAt(x);
                MainMenu.ListeningRecord.GlobalRecentlyPlayedArtist.Insert(0, getset_ArtistName);
            }
            else
            {
                MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs.Insert(0, this.songname);
                MainMenu.ListeningRecord.GlobalRecentlyPlayedArtist.Insert(0, getset_ArtistName);
            }

            MainMenu newform = (MainMenu)this.Parent.Parent.Parent.Parent.Parent;
            newform.MusicPlayer.URL = "D:\\NhatNguyen\\HK1 - Nam_3\\Ngôn Ngữ Lập Trình C#\\Practice\\TH03\\MP3\\" + this.songname + ".mp3";
            newform.MusicPlayer.Ctlcontrols.play();
            newform.ptr_CurrentMusic.Image = Image.FromFile(@"..\\..\\SongImages\" + this.songname + ".jpg"); ; ;
            newform.lbl_CurrentMusicSong.Text = this.songname;
            newform.lbl_CurrentMusicSong.Visible = true;
            newform.lbl_CurrentMusicArtist.Text = getset_ArtistName;
            newform.lbl_CurrentMusicArtist.Visible = true;
            newform.btn_PlayPause.Image = Image.FromFile(@"..\\..\\IconImages\pause.png");

            if (this.like == 0)
            {
                newform.btn_Like.Image = Image.FromFile(@"..\\..\\IconImages\heart.png");
                MainMenu.flag = false;
            }
            else
            {
                newform.btn_Like.Image = Image.FromFile(@"..\\..\\IconImages\filledheart.png");
                MainMenu.flag = true;
            }
        }

        private void ptr_SongImg_Click(object sender, EventArgs e)
        {
            PlayMusic();
        }

        private void Playlist_Song_Click(object sender, EventArgs e)
        {
            PlayMusic();
        }

        private void removeFromThisPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Playlist_Interface newform = (Playlist_Interface)this.Parent.Parent;
            int n = MainMenu.ListPlaylist[newform.ID].getset_SongName.IndexOf(songname);
            MainMenu.ListPlaylist[newform.ID].getset_SongName.RemoveAt(n);
            MainMenu.ListPlaylist[newform.ID].getset_ArtistName.RemoveAt(n);

            newform.lbl_PlaylistName.Text = MainMenu.ListPlaylist[newform.ID].getset_PlaylistName;
            newform.pnl_PlaylistPhoto.BackgroundImage = MainMenu.ListPlaylist[newform.ID].getset_PlaylistPhoto;
            if (MainMenu.ListPlaylist[newform.ID].getset_SongName.Count <= 1)
            {
                newform.lbl_Count.Text = MainMenu.ListPlaylist[newform.ID].getset_SongName.Count.ToString() + " song";
            }
            else
            {
                newform.lbl_Count.Text = MainMenu.ListPlaylist[newform.ID].getset_SongName.Count.ToString() + " songs";
            }

            MainMenu newMainMenu = (MainMenu)this.Parent.Parent.Parent.Parent.Parent;
            foreach (Sidebar_Playlist x in newMainMenu.FlLayout_Playlist.Controls)
            {
                if (MainMenu.ListPlaylist[newform.ID].getset_PlaylistName == x.getset_PlaylistName)
                {
                    x.MyPlaylist_Click(sender, e);
                    break;
                }
            }
        }
    }
}
