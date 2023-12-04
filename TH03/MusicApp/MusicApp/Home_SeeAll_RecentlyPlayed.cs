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
    public partial class Home_SeeAll_RecentlyPlayed : Form
    {
        string songname = "";
        string artistname = "";
        public Home_SeeAll_RecentlyPlayed()
        {
            InitializeComponent();
        }

        private void Home_SeeAll_RecentlyPlayed_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs.Count; i++)
            {
                songname = MainMenu.ListeningRecord.GlobalRecentlyPlayedSongs[i];
                artistname = MainMenu.ListeningRecord.GlobalRecentlyPlayedArtist[i];
                MusicBox x = new MusicBox();
                x.SongName = songname;
                x.ArtistName = artistname;
                x.SongImage = Image.FromFile(@"..\\..\\SongImages\" + songname + ".jpg");
                FlLayout_Container.Controls.Add(x);
            }
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home(), "Home");
        }

        private void btn_Back_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Back.BackgroundImage = Image.FromFile(@"..\\..\\IconImages\Back_MouseMove.png");
        }

        private void btn_Back_MouseLeave(object sender, EventArgs e)
        {
            btn_Back.BackgroundImage = Image.FromFile(@"..\\..\\IconImages\Back_MouseLeave.png");
        }
    }
}
