using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MusicApp
{
    public partial class MainMenu : Form
    {
        public static Form currentChildForm;

        public static string currentForm;

        public static int currentVolume = 50;

        public static string currentSong = "";

        public static int currentID = -1;

        string songname = "";
        string artistname = "";

        int like = 0;

        public static bool flag = false;

        XmlDocument xmlDoc = new XmlDocument();

        public static List<Playlist> ListPlaylist = new List<Playlist>();

        public static Playlist LikeSongsPlaylist = new Playlist("Like Songs Playlist", "", Image.FromFile(@"..\\..\\IconImages\heart.png"));
        XmlDocument Doc = new XmlDocument();

        public MainMenu()
        {
            InitializeComponent();
            customizeDesing();
            UnSelectAll();
            showSubMenu(pnl_Menu);
            showSubMenu(pnl_MyPlaylist);
            select_Home.Visible = true;
            VolumeBar.Value = currentVolume;

            Doc.Load(@"..\\..\\XML\Songs.xml");
            foreach (XmlNode node in Doc.SelectNodes("/Songs" + "/Song"))
            {
                string like = node.SelectSingleNode("Like").InnerText.Trim();
                if (like == "1")
                {
                    songname = node.SelectSingleNode("Name").InnerText.Trim();
                    artistname = node.SelectSingleNode("Artist").InnerText.Trim().Replace(" x ", ", ");
                    LikeSongsPlaylist.getset_SongName.Add(songname);
                    LikeSongsPlaylist.getset_ArtistName.Add(artistname);
                }
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void customizeDesing()
        {
            pnl_Menu.Visible = false;
            pnl_MyPlaylist.Visible = false;
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_Menu);
        }

        private void btn_MyPlaylists_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_MyPlaylist);
        }

        private void rjButton1_MouseDown(object sender, MouseEventArgs e)
        {
            ptr_Home.BackColor = Color.FromArgb(118, 113, 136);
        }

        private void btn_Home_MouseUp(object sender, MouseEventArgs e)
        {
            ptr_Home.BackColor = Color.FromArgb(22, 21, 26);
        }

        private void btn_Search_MouseDown(object sender, MouseEventArgs e)
        {
            ptr_Search.BackColor = Color.FromArgb(118, 113, 136);
        }

        private void btn_Search_MouseUp(object sender, MouseEventArgs e)
        {
            ptr_Search.BackColor = Color.FromArgb(22, 21, 26);
        }

        private void btn_LikedSongs_MouseDown(object sender, MouseEventArgs e)
        {
            ptr_LikedSongs.BackColor = Color.FromArgb(118, 113, 136);
        }

        private void btn_LikedSongs_MouseUp(object sender, MouseEventArgs e)
        {
            ptr_LikedSongs.BackColor = Color.FromArgb(22, 21, 26);
        }

        private void btn_CreateNewPlaylist_MouseDown(object sender, MouseEventArgs e)
        {
            ptr_CreateNewPlaylist.BackColor = Color.FromArgb(118, 113, 136);
        }

        private void btn_CreateNewPlaylist_MouseUp(object sender, MouseEventArgs e)
        {
            ptr_CreateNewPlaylist.BackColor = Color.FromArgb(22, 21, 26);
        }

        public void UnSelectAll()
        {
            select_Home.Visible = false;
            select_Search.Visible = false;
            select_LikedSongs.Visible = false;
            select_CreateNewPlaylist.Visible = false;
        }

        public void Select(Button x)
        {
            UnSelectAll();
            x.Visible = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Select(select_Search);
            OpenChildForm(new Search(), "Search");
        }

        public void btn_Home_Click(object sender, EventArgs e)
        {
            Select(select_Home);
            OpenChildForm(new Home(), "Home");
        }

        private void btn_LikedSongs_Click(object sender, EventArgs e)
        {
            currentID = -2;
            Select(select_LikedSongs);
            OpenChildForm(new LikedSongs(), "LikedSongs");
        }

        private void btn_CreateNewPlaylist_Click(object sender, EventArgs e)
        {
            using(CreatePlaylist newform = new CreatePlaylist())
            {
                if(newform.ShowDialog() == DialogResult.OK)
                {
                    if(CreatePlaylist.flag == true)
                    {
                        Sidebar_Playlist newPlaylist = new Sidebar_Playlist();
                        newPlaylist.getset_PlaylistName = ListPlaylist[ListPlaylist.Count - 1].getset_PlaylistName;
                        newPlaylist.getset_PlaylistDescrip = ListPlaylist[ListPlaylist.Count - 1].getset_PlaylistDescrip;
                        newPlaylist.getset_PlaylistPhoto = ListPlaylist[ListPlaylist.Count - 1].getset_PlaylistPhoto;
                        newPlaylist.getset_id = ListPlaylist.Count - 1;
                        FlLayout_Playlist.Controls.Add(newPlaylist);
                        newPlaylist.MyPlaylist_Click(sender, e);
                    }
                }
            }
        }

        public void OpenChildForm(Form childForm, string FormName)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;

            currentForm = FormName;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_Body.Controls.Add(childForm);
            pnl_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Home(), "Home");

            xmlDoc.Load(@"..\\..\\XML\Songs.xml");
        }

        private void btn_PlayStop_Click(object sender, EventArgs e)
        {
            if(MusicPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                MusicPlayer.Ctlcontrols.pause();
                btn_PlayPause.Image = btn_PlayPause.Image = Image.FromFile(@"..\\..\\IconImages\play.png");
            }
            else
            {
                MusicPlayer.Ctlcontrols.play();
                btn_PlayPause.Image = btn_PlayPause.Image = Image.FromFile(@"..\\..\\IconImages\pause.png");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(MusicPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                ProgressBar.Maximum = (int)MusicPlayer.Ctlcontrols.currentItem.duration;
                ProgressBar.Value = (int)MusicPlayer.Ctlcontrols.currentPosition;
                try
                {
                    lbl_TrackStart.Text = MusicPlayer.Ctlcontrols.currentPositionString;
                    lbl_TrackEnd.Text = MusicPlayer.Ctlcontrols.currentItem.durationString.ToString();
                }
                catch
                {

                }
            }
        }

        private void ProgressBar_MouseDown(object sender, MouseEventArgs e)
        {
            MusicPlayer.Ctlcontrols.currentPosition = MusicPlayer.currentMedia.duration * e.X / ProgressBar.Width;
        }

        public static class ListeningRecord
        {
            private static List<string> RecentlyPlayedSongs = new List<string>();
            private static List<string> RecentlyPlayedArtist = new List<string>();

            private static List<string> RecentSearchesSongs = new List<string>();
            private static List<string> RecentSearchesArtist = new List<string>();

            public static List<string> GlobalRecentlyPlayedSongs
            {
                get
                {
                    return RecentlyPlayedSongs;
                }
                set
                {
                    RecentlyPlayedSongs.Add(value.ToString());
                }
            }

            public static List<string> GlobalRecentlyPlayedArtist
            {
                get
                {
                    return RecentlyPlayedArtist;
                }
                set
                {
                    RecentlyPlayedArtist.Add(value.ToString());
                }
            }

            public static List<string> GlobalRecentSearchesSongs
            {
                get
                {
                    return RecentSearchesSongs;
                }
                set
                {
                    RecentSearchesSongs.Add(value.ToString());
                }
            }

            public static List<string> GlobalRecentSearchesArtist
            {
                get
                {
                    return RecentSearchesArtist;
                }
                set
                {
                    RecentSearchesArtist.Add(value.ToString());
                }
            }
        }

        private void VolumeBar_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            MusicPlayer.settings.volume = VolumeBar.Value;
            currentVolume = VolumeBar.Value;
            if (VolumeBar.Value == 0)
            {
                btn_Volume.Image = Image.FromFile(@"..\\..\\IconImages\mute.png");
            }
            else
            {
                btn_Volume.Image = Image.FromFile(@"..\\..\\IconImages\volume.png");
            }
        }

        private void btn_Volume_Click(object sender, EventArgs e)
        {
            if(VolumeBar.Value != 0)
            {
                VolumeBar.Value = 0;
                MusicPlayer.settings.volume = VolumeBar.Value;
                btn_Volume.Image = Image.FromFile(@"..\\..\\IconImages\mute.png");
            }
            else
            {
                VolumeBar.Value = currentVolume;
                MusicPlayer.settings.volume = VolumeBar.Value;
                btn_Volume.Image = Image.FromFile(@"..\\..\\IconImages\volume.png");
            }
        }

        private void btn_Like_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void btn_Like_MouseLeave(object sender, EventArgs e)
        {
        }

        private void btn_Like_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                btn_Like.Image = Image.FromFile(@"..\\..\\IconImages\filledheart.png");
                flag = true;
                foreach (XmlNode node in xmlDoc.SelectNodes("/Songs" + "/Song"))
                {
                    string Name = node.SelectSingleNode("Name").InnerText.Trim();
                    if (Name == currentSong)
                    {
                        XmlNode likeNode = node.SelectSingleNode("Like");
                        likeNode.InnerText = "1";
                        break;
                    }
                }
                xmlDoc.Save(@"..\\..\\XML\Songs.xml");

                if (currentForm == "LikedSongs")
                {
                    btn_LikedSongs_Click(sender, e);
                }

                Doc.Load(@"..\\..\\XML\Songs.xml");
                LikeSongsPlaylist.getset_SongName.Clear();
                LikeSongsPlaylist.getset_ArtistName.Clear();
                foreach (XmlNode node in Doc.SelectNodes("/Songs" + "/Song"))
                {
                    string like = node.SelectSingleNode("Like").InnerText.Trim();
                    if (like == "1")
                    {
                        songname = node.SelectSingleNode("Name").InnerText.Trim();
                        artistname = node.SelectSingleNode("Artist").InnerText.Trim().Replace(" x ", ", ");
                        LikeSongsPlaylist.getset_SongName.Add(songname);
                        LikeSongsPlaylist.getset_ArtistName.Add(artistname);
                    }
                }
            }
            else
            {
                btn_Like.Image = Image.FromFile(@"..\\..\\IconImages\heart.png");
                flag = false;
                foreach (XmlNode node in xmlDoc.SelectNodes("/Songs" + "/Song"))
                {
                    string Name = node.SelectSingleNode("Name").InnerText.Trim();
                    if (Name == currentSong)
                    {
                        XmlNode likeNode = node.SelectSingleNode("Like");
                        likeNode.InnerText = "0";
                        break;
                    }
                }
                xmlDoc.Save(@"..\\..\\XML\Songs.xml");

                if (currentForm == "LikedSongs")
                {
                    btn_LikedSongs_Click(sender, e);
                }

                Doc.Load(@"..\\..\\XML\Songs.xml");
                LikeSongsPlaylist.getset_SongName.Clear();
                LikeSongsPlaylist.getset_ArtistName.Clear();
                foreach (XmlNode node in Doc.SelectNodes("/Songs" + "/Song"))
                {
                    string like = node.SelectSingleNode("Like").InnerText.Trim();
                    if (like == "1")
                    {
                        songname = node.SelectSingleNode("Name").InnerText.Trim();
                        artistname = node.SelectSingleNode("Artist").InnerText.Trim().Replace(" x ", ", ");
                        LikeSongsPlaylist.getset_SongName.Add(songname);
                        LikeSongsPlaylist.getset_ArtistName.Add(artistname);
                    }
                }
            }
      
        }

        public void PlayMusic(string song, string artist)
        {
            MainMenu.currentSong = song;
            xmlDoc.Load(@"..\\..\\XML\Songs.xml");

            foreach (XmlNode node in xmlDoc.SelectNodes("/Songs" + "/Song"))
            {
                string Name = node.SelectSingleNode("Name").InnerText.Trim();
                if (Name == song)
                {
                    XmlNode likeNode = node.SelectSingleNode("Like");
                    this.like = Convert.ToInt32(likeNode.InnerText.Trim());
                    break;
                }
            }

            if (MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs.Contains(song) == true)
            {
                int x = MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs.IndexOf(song);
                MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs.RemoveAt(x);
                MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs.Insert(0, song);
                MainMenu.ListeningRecord.GlobalRecentlyPlayedArtist.RemoveAt(x);
                MainMenu.ListeningRecord.GlobalRecentlyPlayedArtist.Insert(0, artist);
            }
            else
            {
                MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs.Insert(0, song);
                MainMenu.ListeningRecord.GlobalRecentlyPlayedArtist.Insert(0, artist);
            }

            this.MusicPlayer.URL = "D:\\NhatNguyen\\HK1 - Nam_3\\Ngôn Ngữ Lập Trình C#\\Practice\\TH03\\MP3\\" + song + ".mp3";
            this.MusicPlayer.Ctlcontrols.play();
            this.ptr_CurrentMusic.Image = Image.FromFile(@"..\\..\\SongImages\" + song + ".jpg"); ; ;
            this.lbl_CurrentMusicSong.Text = song;
            this.lbl_CurrentMusicSong.Visible = true;
            this.lbl_CurrentMusicArtist.Text = artist;
            this.lbl_CurrentMusicArtist.Visible = true;
            this.btn_PlayPause.Image = Image.FromFile(@"..\\..\\IconImages\pause.png");

            if (this.like == 0)
            {
                this.btn_Like.Image = Image.FromFile(@"..\\..\\IconImages\heart.png");
                MainMenu.flag = false;
            }
            else
            {
                this.btn_Like.Image = Image.FromFile(@"..\\..\\IconImages\filledheart.png");
                MainMenu.flag = true;
            }
        }

        private void btn_NextTrack_Click(object sender, EventArgs e)
        {
            int p;
            if (currentID > -1)
            {
                p = MainMenu.ListPlaylist[currentID].getset_SongName.IndexOf(MainMenu.currentSong);
                if (p == MainMenu.ListPlaylist[currentID].getset_SongName.Count - 1)
                {
                    p = 0;
                }
                else
                {
                    p++;
                }
                PlayMusic(MainMenu.ListPlaylist[currentID].getset_SongName[p], MainMenu.ListPlaylist[currentID].getset_ArtistName[p]);
            }
            else if(currentID == -2)
            {
                p = MainMenu.LikeSongsPlaylist.getset_SongName.IndexOf(MainMenu.currentSong);
                if (p == MainMenu.LikeSongsPlaylist.getset_SongName.Count - 1)
                {
                    p = 0;
                }
                else
                {
                    p++;
                }
                PlayMusic(MainMenu.LikeSongsPlaylist.getset_SongName[p], MainMenu.LikeSongsPlaylist.getset_ArtistName[p]);
            }
        }

        private void btn_PreviousTrack_Click(object sender, EventArgs e)
        {
            int p;
            if (currentID > -1)
            {
                p = MainMenu.ListPlaylist[currentID].getset_SongName.IndexOf(MainMenu.currentSong);
                if (p == 0)
                {
                    p = MainMenu.ListPlaylist[currentID].getset_SongName.Count - 1;
                }
                else
                {
                    p--;
                }
                PlayMusic(MainMenu.ListPlaylist[currentID].getset_SongName[p], MainMenu.ListPlaylist[currentID].getset_ArtistName[p]);
            }
            else if (currentID == -2)
            {
                p = MainMenu.LikeSongsPlaylist.getset_SongName.IndexOf(MainMenu.currentSong);
                if (p == 0)
                {
                    p = MainMenu.LikeSongsPlaylist.getset_SongName.Count - 1;
                }
                else
                {
                    p--;
                }
                PlayMusic(MainMenu.LikeSongsPlaylist.getset_SongName[p], MainMenu.LikeSongsPlaylist.getset_ArtistName[p]);
            }
        }
    }
}
