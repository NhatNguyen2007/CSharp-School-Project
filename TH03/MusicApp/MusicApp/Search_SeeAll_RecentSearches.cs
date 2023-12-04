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
    public partial class Search_SeeAll_RecentSearches : Form
    {
        string songname = "";
        string artistname = "";
        public Search_SeeAll_RecentSearches()
        {
            InitializeComponent();
        }

        private void btn_Back_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Back.BackgroundImage = Image.FromFile(@"..\\..\\IconImages\Back_MouseMove.png");
        }

        private void btn_Back_MouseLeave(object sender, EventArgs e)
        {
            btn_Back.BackgroundImage = Image.FromFile(@"..\\..\\IconImages\Back_MouseLeave.png");
        }

        private void Search_SeeAll_RecentSearches_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < MainMenu.ListeningRecord.GlobalRecentSearchesSongs.Count; i++)
            {
                songname = MainMenu.ListeningRecord.GlobalRecentSearchesSongs[i];
                artistname = MainMenu.ListeningRecord.GlobalRecentSearchesArtist[i];
                MusicBox x = new MusicBox();
                x.SongName = songname;
                x.ArtistName = artistname;
                x.SongImage = Image.FromFile(@"..\\..\\SongImages\" + songname + ".jpg");
                FlLayout_Container.Controls.Add(x);
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Default_Search_Interface(), "Default_Search_Interface");
        }
    }
}
