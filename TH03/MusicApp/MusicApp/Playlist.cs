using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MusicApp
{
    public class Playlist
    {
        private string PlaylistName = "";
        private string PlaylistDescrip = "";
        private Image PlaylistPhoto;
        private List<string> SongName = new List<string>();
        private List<string> ArtistName = new List<string>();

        public Playlist(string playlistname, string playlistdescrip, Image playlistphoto)
        {
            this.PlaylistName = playlistname;
            this.PlaylistDescrip = playlistdescrip;
            this.PlaylistPhoto = playlistphoto;
        }

        public string getset_PlaylistName
        {
            get
            {
                return PlaylistName;
            }
            set
            {
                PlaylistName = value;
            }
        }

        public string getset_PlaylistDescrip
        {
            get
            {
                return PlaylistDescrip;
            }
            set
            {
                PlaylistDescrip = value;
            }
        }

        public Image getset_PlaylistPhoto
        {
            get
            {
                return PlaylistPhoto;
            }
            set
            {
                PlaylistPhoto = value;
            }
        }

        public List<string> getset_SongName
        {
            get
            {
                return SongName;
            }
            set
            {
                SongName.Add(value.ToString());
            }
        }

        public List<string> getset_ArtistName
        {
            get
            {
                return ArtistName;
            }
            set
            {
                ArtistName.Add(value.ToString());
            }
        }
    }
}
