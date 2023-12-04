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
    public partial class Home : Form
    {
        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList nodeList = null;
        string songname = "";
        string artistname = "";
        string playlistname = "";
        Image playlistphoto;

        public Random rd = new Random();
        public int Numbrd = 0;
        public List<int> ListRand = new List<int>();

        public int CurrentAdDisplayedSong = 0;

        public Home()
        {
            InitializeComponent();
        }

        public void GetRandom(int n)
        {
            int i = 0;
            ListRand.Clear();
            while (i < n)
            {
                Numbrd = rd.Next(0, nodeList.Count);
                if (ListRand.Contains(Numbrd) == false)
                {
                    ListRand.Add(Numbrd);
                    i++;
                }
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            xmlDoc.Load(@"..\\..\\XML\Songs.xml");
            nodeList = xmlDoc.SelectNodes("/Songs" + "/Song");

            CurrentAdDisplayedSong = rd.Next(0, nodeList.Count);
            songname = nodeList[CurrentAdDisplayedSong].SelectSingleNode("Name").InnerText.Trim();
            pnl_AdFlyer.BackgroundImage = Image.FromFile(@"..\\..\\AdFlyers\SongPnlAdFlyers\" + songname + ".jpg");
            ptr_CenterAdFlyer.Image = Image.FromFile(@"..\\..\\AdFlyers\SongAdFlyers\" + songname + ".jpg");

            GetRandom(5);

            for (int i = 0; i < ListRand.Count; i++)
            {
                songname = nodeList[ListRand[i]].SelectSingleNode("Name").InnerText.Trim();
                artistname = nodeList[ListRand[i]].SelectSingleNode("Artist").InnerText.Trim();
                MusicBox x = new MusicBox();
                x.SongName = songname;
                x.ArtistName = artistname;
                x.SongImage = Image.FromFile(@"..\\..\\SongImages\" + songname + ".jpg");
                FlLayout_MadeForYou.Controls.Add(x);
            }

            for (int i = 0; i < MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs.Count; i++)
            {
                songname = MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs[i];
                artistname = MainMenu.ListeningRecord.GlobalRecentlyPlayedArtist[i];
                MusicBox x = new MusicBox();
                x.SongName = songname;
                x.ArtistName = artistname;
                x.SongImage = Image.FromFile(@"..\\..\\SongImages\" + songname + ".jpg");
                FlLayout_RecentlyPlayed.Controls.Add(x);
            }

            for(int i=0; i<MainMenu.ListPlaylist.Count && i<5; i++)
            {
                playlistname = MainMenu.ListPlaylist[i].getset_PlaylistName;
                playlistphoto = MainMenu.ListPlaylist[i].getset_PlaylistPhoto;
                MusicBox x = new MusicBox();
                x.SongName = playlistname;
                x.SongImage = playlistphoto;
                x.setVisible();
                FlLayout_YoutPlaylists.Controls.Add(x);
            }
        }

        private void btn_Like_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Like.BackgroundImage = Image.FromFile(@"..\\..\\IconImages\filled_circleheart.png");
        }

        private void btn_Like_MouseLeave(object sender, EventArgs e)
        {
            btn_Like.BackgroundImage = Image.FromFile(@"..\\..\\IconImages\circleheart.png");
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

        private void btn_SeeAll_MadeForYou_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home_SeeAll_MadeForYou(), "Home_SeeAll_MadeForYou");
        }

        private void btn_PlaySong_Click(object sender, EventArgs e)
        {
            this.songname = nodeList[CurrentAdDisplayedSong].SelectSingleNode("Name").InnerText.Trim();
            this.artistname = nodeList[CurrentAdDisplayedSong].SelectSingleNode("Artist").InnerText.Trim();
            PlayMusic();
        }

        public void PlayMusic()
        {
            if (MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs.Contains(this.songname) == true)
            {
                int x = MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs.IndexOf(this.songname);
                MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs.RemoveAt(x);
                MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs.Insert(0, this.songname);
                MainMenu.ListeningRecord.GlobalRecentlyPlayedArtist.RemoveAt(x);
                MainMenu.ListeningRecord.GlobalRecentlyPlayedArtist.Insert(0, this.artistname);
            }
            else
            {
                MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs.Insert(0, this.songname);
                MainMenu.ListeningRecord.GlobalRecentlyPlayedArtist.Insert(0, this.artistname);
            }

            MainMenu newform = (MainMenu)this.Parent.Parent.Parent;
            newform.MusicPlayer.URL = "D:\\NhatNguyen\\HK1 - Nam_3\\Ngôn Ngữ Lập Trình C#\\Practice\\TH03\\MP3\\" + this.songname + ".mp3";
            newform.MusicPlayer.Ctlcontrols.play();
            newform.ptr_CurrentMusic.Image = Image.FromFile(@"..\\..\\SongImages\" + this.songname + ".jpg"); ;
            newform.lbl_CurrentMusicSong.Text = this.songname;
            newform.lbl_CurrentMusicSong.Visible = true;
            newform.lbl_CurrentMusicArtist.Text = this.artistname.Replace(" x ", ", "); 
            newform.lbl_CurrentMusicArtist.Visible = true;
            newform.btn_PlayPause.Image = Image.FromFile(@"..\\..\\IconImages\pause.png");

            FlLayout_RecentlyPlayed.Controls.Clear();
            for (int i = 0; i < MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs.Count && i < 5; i++)
            {
                songname = MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs[i];
                artistname = MainMenu.ListeningRecord.GlobalRecentlyPlayedArtist[i];
                MusicBox x = new MusicBox();
                x.SongName = songname;
                x.ArtistName = artistname;
                x.SongImage = Image.FromFile(@"..\\..\\SongImages\" + songname + ".jpg");
                FlLayout_RecentlyPlayed.Controls.Add(x);
            }
        }

        private void btn_SeeAll_RecentlyPlayed_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home_SeeAll_RecentlyPlayed(), "Home_SeeAll_RecentlyPlayed");
        }

        private void btn_SeeAll_YourPlaylists_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home_SeeAll_YourPlaylists(), "Home_SeeAll_YourPlaylists");
        }
    }
}
