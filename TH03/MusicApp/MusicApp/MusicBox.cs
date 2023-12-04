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
using System.IO;
using System.Globalization;

namespace MusicApp
{
    public partial class MusicBox : UserControl
    {
        string songname = "";
        string artistname = "";

        string temp_name = "";
        string temp_artist = "";

        string despath = "";
        string fileToCopy = "";

        int like = 0;

        XmlDocument xmlDoc = new XmlDocument();

        public MusicBox()
        {
            InitializeComponent();
        }

        public Image SongImage
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

        public string SongName
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

        public string ArtistName
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

        public void setVisible()
        {
            if(lbl_ArtistName.Visible)
            {
                lbl_ArtistName.Visible = false;
            }
        }

        private void pnl_wrapper_MouseMove(object sender, MouseEventArgs e)
        {
            pnl_wrapper.BackgroundColor = Color.FromArgb(56, 51, 69);
        }

        private void pnl_wrapper_MouseLeave(object sender, EventArgs e)
        {
            pnl_wrapper.BackgroundColor = Color.FromArgb(36, 33, 41);
        }

        private void ptr_SongImg_MouseMove(object sender, MouseEventArgs e)
        {
            pnl_wrapper.BackgroundColor = Color.FromArgb(56, 51, 69);
        }

        private void ptr_SongImg_MouseLeave(object sender, EventArgs e)
        {
            pnl_wrapper.BackgroundColor = Color.FromArgb(36, 33, 41);
        }

        private void lbl_SongName_MouseMove(object sender, MouseEventArgs e)
        {
            pnl_wrapper.BackgroundColor = Color.FromArgb(56, 51, 69);
        }

        private void lbl_SongName_MouseLeave(object sender, EventArgs e)
        {
            pnl_wrapper.BackgroundColor = Color.FromArgb(36, 33, 41);
        }

        private void lbl_ArtistName_MouseMove(object sender, MouseEventArgs e)
        {
            pnl_wrapper.BackgroundColor = Color.FromArgb(56, 51, 69);
        }

        private void lbl_ArtistName_MouseLeave(object sender, EventArgs e)
        {
            pnl_wrapper.BackgroundColor = Color.FromArgb(36, 33, 41);
        }

        private void lbl_ArtistName_Click(object sender, EventArgs e)
        {

        }

        private void MusicBox_Load(object sender, EventArgs e)
        {
            if (lbl_ArtistName.Visible == false)
            {
                rjDropDownMenu1.Items[0].Visible = false;
                rjDropDownMenu1.Items[1].Visible = false;
            }
            rjDropDownMenu1.IsMainMenu = true;
            songname = SongName;
            artistname = ArtistName;

            this.ArtistName = artistname.Replace(" x ", "\n");

            if (songname.Length > 12 && lbl_ArtistName.Visible == true)
            {
                this.SongName = songname.Substring(0, 13) + "...";
            }
            else
            {
                this.SongName = songname;
            }
        }

        public void PlayMusic()
        {
            MainMenu.currentSong = this.songname;
            xmlDoc.Load(@"..\\..\\XML\Songs.xml");

            foreach (XmlNode node in xmlDoc.SelectNodes("/Songs" + "/Song"))
            {
                string Name = node.SelectSingleNode("Name").InnerText.Trim();
                if(Name == this.songname)
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
                MainMenu.ListeningRecord.GlobalRecentlyPlayedArtist.Insert(0, this.artistname);
            }
            else
            {
                MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs.Insert(0, this.songname);
                MainMenu.ListeningRecord.GlobalRecentlyPlayedArtist.Insert(0, this.artistname);
            }

            if (MainMenu.currentForm == "Home")
            {
                MainMenu newform = (MainMenu)this.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                newform.MusicPlayer.URL = "D:\\NhatNguyen\\HK1 - Nam_3\\Ngôn Ngữ Lập Trình C#\\Practice\\TH03\\MP3\\" + this.songname + ".mp3";
                newform.MusicPlayer.Ctlcontrols.play();
                newform.ptr_CurrentMusic.Image = Image.FromFile(@"..\\..\\SongImages\" + this.songname + ".jpg"); ; ;
                newform.lbl_CurrentMusicSong.Text = this.songname;
                newform.lbl_CurrentMusicSong.Visible = true;
                newform.lbl_CurrentMusicArtist.Text = this.artistname.Replace(" x ", ", ");
                newform.lbl_CurrentMusicArtist.Visible = true;
                newform.btn_PlayPause.Image = Image.FromFile(@"..\\..\\IconImages\pause.png");

                if(this.like == 0)
                {
                    newform.btn_Like.Image = Image.FromFile(@"..\\..\\IconImages\heart.png");
                    MainMenu.flag = false;
                }
                else
                {
                    newform.btn_Like.Image = Image.FromFile(@"..\\..\\IconImages\filledheart.png");
                    MainMenu.flag = true;
                }

                Home newHome = (Home)this.Parent.Parent.Parent.Parent;
                newHome.FlLayout_RecentlyPlayed.Controls.Clear();
                for (int i = 0; i < MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs.Count && i < 5; i++)
                {
                    temp_name = MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs[i];
                    temp_artist = MainMenu.ListeningRecord.GlobalRecentlyPlayedArtist[i];
                    MusicBox x = new MusicBox();
                    x.SongName = temp_name;
                    x.ArtistName = temp_artist;
                    x.SongImage = Image.FromFile(@"..\\..\\SongImages\" + temp_name + ".jpg");
                    newHome.FlLayout_RecentlyPlayed.Controls.Add(x);
                }
            }
            else if (MainMenu.currentForm == "Home_SeeAll_MadeForYou")
            {
                MainMenu newform = (MainMenu)this.Parent.Parent.Parent.Parent.Parent.Parent;
                newform.MusicPlayer.URL = "D:\\NhatNguyen\\HK1 - Nam_3\\Ngôn Ngữ Lập Trình C#\\Practice\\TH03\\MP3\\" + this.songname + ".mp3";
                newform.MusicPlayer.Ctlcontrols.play();
                newform.ptr_CurrentMusic.Image = Image.FromFile(@"..\\..\\SongImages\" + this.songname + ".jpg"); ;
                newform.lbl_CurrentMusicSong.Text = this.songname;
                newform.lbl_CurrentMusicSong.Visible = true;
                newform.lbl_CurrentMusicArtist.Text = this.artistname.Replace(" x ", ", ");
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
            else if(MainMenu.currentForm == "Home_SeeAll_RecentlyPlayed")
            {
                MainMenu newform = (MainMenu)this.Parent.Parent.Parent.Parent.Parent.Parent;
                newform.MusicPlayer.URL = "D:\\NhatNguyen\\HK1 - Nam_3\\Ngôn Ngữ Lập Trình C#\\Practice\\TH03\\MP3\\" + this.songname + ".mp3";
                newform.MusicPlayer.Ctlcontrols.play();
                newform.ptr_CurrentMusic.Image = Image.FromFile(@"..\\..\\SongImages\" + this.songname + ".jpg"); ;
                newform.lbl_CurrentMusicSong.Text = this.songname;
                newform.lbl_CurrentMusicSong.Visible = true;
                newform.lbl_CurrentMusicArtist.Text = this.artistname.Replace(" x ", ", ");
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

                Home_SeeAll_RecentlyPlayed newHomeSeeAllRecentlyPlayed = (Home_SeeAll_RecentlyPlayed)this.Parent.Parent.Parent;
                newHomeSeeAllRecentlyPlayed.FlLayout_Container.Controls.Clear();
                for (int i = 0; i < MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs.Count; i++)
                {
                    temp_name = MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs[i];
                    temp_artist = MainMenu.ListeningRecord.GlobalRecentlyPlayedArtist[i];
                    MusicBox x = new MusicBox();
                    x.SongName = temp_name;
                    x.ArtistName = temp_artist;
                    x.SongImage = Image.FromFile(@"..\\..\\SongImages\" + temp_name + ".jpg");
                    newHomeSeeAllRecentlyPlayed.FlLayout_Container.Controls.Add(x);
                }

            }
            else if (MainMenu.currentForm == "Search")
            {
                if(Search.currentForm == "Search_Interface")
                {
                    if (MainMenu.ListeningRecord.GlobalRecentSearchesSongs.Contains(this.songname) == true)
                    {
                        int x = MainMenu.ListeningRecord.GlobalRecentSearchesSongs.IndexOf(this.songname);
                        MainMenu.ListeningRecord.GlobalRecentSearchesSongs.RemoveAt(x);
                        MainMenu.ListeningRecord.GlobalRecentSearchesSongs.Insert(0, this.songname);
                        MainMenu.ListeningRecord.GlobalRecentSearchesArtist.RemoveAt(x);
                        MainMenu.ListeningRecord.GlobalRecentSearchesArtist.Insert(0, this.artistname);
                    }
                    else
                    {
                        MainMenu.ListeningRecord.GlobalRecentSearchesSongs.Insert(0, this.songname);
                        MainMenu.ListeningRecord.GlobalRecentSearchesArtist.Insert(0, this.artistname);
                    }

                    MainMenu newform = (MainMenu)this.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                    newform.MusicPlayer.URL = "D:\\NhatNguyen\\HK1 - Nam_3\\Ngôn Ngữ Lập Trình C#\\Practice\\TH03\\MP3\\" + this.songname + ".mp3";
                    newform.MusicPlayer.Ctlcontrols.play();
                    newform.ptr_CurrentMusic.Image = Image.FromFile(@"..\\..\\SongImages\" + this.songname + ".jpg"); ;
                    newform.lbl_CurrentMusicSong.Text = this.songname;
                    newform.lbl_CurrentMusicSong.Visible = true;
                    newform.lbl_CurrentMusicArtist.Text = this.artistname.Replace(" x ", ", ");
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
                else if (Search.currentForm == "Default_Search_Interface")
                {
                    MainMenu newform = (MainMenu)this.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                    newform.MusicPlayer.URL = "D:\\NhatNguyen\\HK1 - Nam_3\\Ngôn Ngữ Lập Trình C#\\Practice\\TH03\\MP3\\" + this.songname + ".mp3";
                    newform.MusicPlayer.Ctlcontrols.play();
                    newform.ptr_CurrentMusic.Image = Image.FromFile(@"..\\..\\SongImages\" + this.songname + ".jpg"); ;
                    newform.lbl_CurrentMusicSong.Text = this.songname;
                    newform.lbl_CurrentMusicSong.Visible = true;
                    newform.lbl_CurrentMusicArtist.Text = this.artistname.Replace(" x ", ", ");
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
                else if(Search.currentForm == "Genre_Interface")
                {
                    MainMenu newform = (MainMenu)this.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                    newform.MusicPlayer.URL = "D:\\NhatNguyen\\HK1 - Nam_3\\Ngôn Ngữ Lập Trình C#\\Practice\\TH03\\MP3\\" + this.songname + ".mp3";
                    newform.MusicPlayer.Ctlcontrols.play();
                    newform.ptr_CurrentMusic.Image = Image.FromFile(@"..\\..\\SongImages\" + this.songname + ".jpg"); ;
                    newform.lbl_CurrentMusicSong.Text = this.songname;
                    newform.lbl_CurrentMusicSong.Visible = true;
                    newform.lbl_CurrentMusicArtist.Text = this.artistname.Replace(" x ", ", ");
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
                else if(Search.currentForm == "Search_SeeAll_RecentSearches")
                {
                    MainMenu newform = (MainMenu)this.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                    newform.MusicPlayer.URL = "D:\\NhatNguyen\\HK1 - Nam_3\\Ngôn Ngữ Lập Trình C#\\Practice\\TH03\\MP3\\" + this.songname + ".mp3";
                    newform.MusicPlayer.Ctlcontrols.play();
                    newform.ptr_CurrentMusic.Image = Image.FromFile(@"..\\..\\SongImages\" + this.songname + ".jpg"); ;
                    newform.lbl_CurrentMusicSong.Text = this.songname;
                    newform.lbl_CurrentMusicSong.Visible = true;
                    newform.lbl_CurrentMusicArtist.Text = this.artistname.Replace(" x ", ", ");
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

            }
        }

        private void ptr_SongImg_Click(object sender, EventArgs e)
        {
            MainMenu.currentID = -1;
            if (lbl_ArtistName.Visible == true)
            {
                PlayMusic();
            }
            else
            {
                if(MainMenu.currentForm == "Home")
                {
                    MainMenu newform = (MainMenu)this.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                    foreach (Sidebar_Playlist x in newform.FlLayout_Playlist.Controls)
                    {
                        if (songname == x.getset_PlaylistName)
                        {
                            x.MyPlaylist_Click(sender, e);
                            break;
                        }
                    }
                }
                else if (MainMenu.currentForm == "Home_SeeAll_YourPlaylists")
                {
                    MainMenu newform = (MainMenu)this.Parent.Parent.Parent.Parent.Parent.Parent;
                    foreach (Sidebar_Playlist x in newform.FlLayout_Playlist.Controls)
                    {
                        if (songname == x.getset_PlaylistName)
                        {
                            x.MyPlaylist_Click(sender, e);
                            break;
                        }
                    }
                }
            }
        }

        private void pnl_wrapper_Click(object sender, EventArgs e)
        {
            MainMenu.currentID = -1;
            if (lbl_ArtistName.Visible == true)
            {
                PlayMusic();
            }
            else
            {
                if (MainMenu.currentForm == "Home")
                {
                    MainMenu newform = (MainMenu)this.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                    foreach (Sidebar_Playlist x in newform.FlLayout_Playlist.Controls)
                    {
                        if (songname == x.getset_PlaylistName)
                        {
                            x.MyPlaylist_Click(sender, e);
                            break;
                        }
                    }
                }
                else if(MainMenu.currentForm == "Home_SeeAll_YourPlaylists")
                {
                    MainMenu newform = (MainMenu)this.Parent.Parent.Parent.Parent.Parent.Parent;
                    foreach (Sidebar_Playlist x in newform.FlLayout_Playlist.Controls)
                    {
                        if (songname == x.getset_PlaylistName)
                        {
                            x.MyPlaylist_Click(sender, e);
                            break;
                        }
                    }
                }
            }
        }

        private void ptr_SongImg_DoubleClick(object sender, EventArgs e)
        {
        }

        private void addToPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddToPlaylist_Interface newform = new AddToPlaylist_Interface(this.songname, this.artistname))
            {
                if (newform.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                despath = ofd.SelectedPath;
            }


            fileToCopy = "D:\\NhatNguyen\\HK1 - Nam_3\\Ngôn Ngữ Lập Trình C#\\Practice\\TH03\\MP3\\" + this.songname + ".mp3";
            File.Copy(fileToCopy, despath + Path.GetFileName(fileToCopy));

        }
    }
}
