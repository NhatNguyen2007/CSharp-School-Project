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
    public partial class Sidebar_Playlist : UserControl
    {
        private string PlaylistName = "";
        private string PlaylistDescrip = "";
        private Image PlaylistPhoto;
        private int id;

        string playlistname = "";
        Image playlistphoto;
        public Sidebar_Playlist()
        {
            InitializeComponent();
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

        public int getset_id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        private void MyPlaylist_Load(object sender, EventArgs e)
        {
            rjDropDownMenu1.IsMainMenu = true;
            PlaylistName = getset_PlaylistName;
        }

        public void OpenPlaylist(Form childForm)
        {
            MainMenu newform = (MainMenu)this.Parent.Parent.Parent.Parent;

            if (MainMenu.currentChildForm != null)
            {
                MainMenu.currentChildForm.Close();
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            newform.pnl_Body.Controls.Add(childForm);
            newform.pnl_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void MyPlaylist_Click(object sender, EventArgs e)
        {
            MainMenu.currentID = getset_id;
            OpenPlaylist(new Playlist_Interface(getset_PlaylistName, getset_PlaylistDescrip, getset_PlaylistPhoto, getset_id));
        }

        public void lbl_PlaylistName_Click(object sender, EventArgs e)
        {
            MainMenu.currentID = getset_id;
            OpenPlaylist(new Playlist_Interface(getset_PlaylistName, getset_PlaylistDescrip, getset_PlaylistPhoto, getset_id));
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenu.ListPlaylist.RemoveAt(getset_id);
            MainMenu newform = (MainMenu)this.Parent.Parent.Parent.Parent;
            newform.FlLayout_Playlist.Controls.Clear();
            for(int i=0; i<MainMenu.ListPlaylist.Count; i++)
            {
                Sidebar_Playlist newPlaylist = new Sidebar_Playlist();
                newPlaylist.getset_PlaylistName = MainMenu.ListPlaylist[i].getset_PlaylistName;
                newPlaylist.getset_PlaylistPhoto = MainMenu.ListPlaylist[i].getset_PlaylistPhoto;
                newPlaylist.getset_PlaylistDescrip = MainMenu.ListPlaylist[i].getset_PlaylistDescrip;
                newPlaylist.getset_id = i;
                newform.FlLayout_Playlist.Controls.Add(newPlaylist);
            }
            if (MainMenu.currentForm == "Home")
            {
                newform.btn_Home_Click(sender, e);
            }
        }
    }
}
