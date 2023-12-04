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
    public partial class LikedSongs : Form
    {
        XmlDocument xmlDoc = new XmlDocument();


        public LikedSongs()
        {
            InitializeComponent();
        }

        private void LikedSongs_Load(object sender, EventArgs e)
        {
            xmlDoc.Load(@"..\\..\\XML\Songs.xml");
            foreach (XmlNode node in xmlDoc.SelectNodes("/Songs" + "/Song"))
            {
                string like = node.SelectSingleNode("Like").InnerText.Trim();
                if (like == "1")
                {
                    Playlist_Song newsong = new Playlist_Song();
                    newsong.getset_SongName = node.SelectSingleNode("Name").InnerText.Trim(); ;
                    newsong.getset_ArtistName = node.SelectSingleNode("Artist").InnerText.Trim().Replace(" x ", ", ");
                    newsong.getset_SongImage = Image.FromFile(@"..\\..\\SongImages\" + newsong.getset_SongName + ".jpg");
                    FlLayout_PlaylistSong.Controls.Add(newsong);
                }
            }
        }
    }
}
