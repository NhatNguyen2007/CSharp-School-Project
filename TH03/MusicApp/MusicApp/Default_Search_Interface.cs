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
    public partial class Default_Search_Interface : Form
    {
        string songname = "";
        string artistname = "";

        public static List<string> genre = new List<string>()
        {
            "Vietnamese Music", "Viet Rap", "USUK", "Rock", "Pop", "EDM", "Indie", "K-Pop"
        };
        public static List<Color> color = new List<Color>()
        {
            Color.FromArgb(140,25,50), 
            Color.FromArgb(119, 119, 119), 
            Color.FromArgb(125, 75, 50), 
            Color.FromArgb(188,89,0), 
            Color.FromArgb(233,20,41), 
            Color.FromArgb(30,50,100),
            Color.FromArgb(220,20,140),
            Color.FromArgb(132,0,231)
        };

        public Default_Search_Interface()
        {
            InitializeComponent();
        }

        private void Default_Search_Interface_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < MainMenu.ListeningRecord.GlobalRecentSearchesSongs.Count && i<5; i++)
            {
                songname = MainMenu.ListeningRecord.GlobalRecentSearchesSongs[i];
                artistname = MainMenu.ListeningRecord.GlobalRecentSearchesArtist[i];
                MusicBox x = new MusicBox();
                x.SongName = songname;
                x.ArtistName = artistname;
                x.SongImage = Image.FromFile(@"..\\..\\SongImages\" + songname + ".jpg");
                FlLayout_RecentSearches.Controls.Add(x);
            }

            int j = 0;
            foreach(GenreBox x in FlLayout_BrowseAll.Controls)
            {
                x.getset_GenreName = genre[j];
                x.getset_GenreImg = Image.FromFile(@"..\\..\\RotateImg\" + genre[j] + ".png");
                x.getset_ContainerColor = color[j];
                j++;
            }
        }

        public void OpenChildForm(Form childForm, string currentform)
        {
            Search newform = (Search)this.Parent.Parent;

            if (Search.currentChildForm != null)
            {
                Search.currentChildForm.Close();
            }

            Search.currentChildForm = childForm;
            Search.currentForm = currentform;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            newform.pnl_Container.Controls.Add(childForm);
            newform.pnl_Container.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_SeeAll_RecentSearches_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Search_SeeAll_RecentSearches(), "Search_SeeAll_RecentSearches");
        }
    }
}
