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
    public partial class Genre_Interface : Form
    {
        string Genre = "";
        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList nodeList = null;
        string songname = "";
        string artistname = "";
        string genre = "";
        public Genre_Interface(string genreee)
        {
            InitializeComponent();
            Genre = genreee;
        }

        private void Genre_Interface_Load(object sender, EventArgs e)
        {
            pnl_Header.GradientTopLeft = Default_Search_Interface.color[Default_Search_Interface.genre.IndexOf(Genre)];
            pnl_Header.GradientTopRight = Default_Search_Interface.color[Default_Search_Interface.genre.IndexOf(Genre)];
            lbl_Title.Text = Genre;

            xmlDoc.Load(@"..\\..\\XML\Songs.xml");
            nodeList = xmlDoc.SelectNodes("/Songs" + "/Song");
            for (int i = 0; i < nodeList.Count; i++)
            {
                genre = nodeList[i].SelectSingleNode("Genre").InnerText.Trim();
                if (genre.ToLower().Contains(Genre.ToLower()))
                {
                    songname = nodeList[i].SelectSingleNode("Name").InnerText.Trim();
                    artistname = nodeList[i].SelectSingleNode("Artist").InnerText.Trim();
                    MusicBox x = new MusicBox();
                    x.SongName = songname;
                    x.ArtistName = artistname;
                    x.SongImage = Image.FromFile(@"..\\..\\SongImages\" + songname + ".jpg");
                    FlLayout_Container.Controls.Add(x);
                }
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

        private void btn_Back_MouseMove_1(object sender, MouseEventArgs e)
        {
            btn_Back.BackgroundImage = Image.FromFile(@"..\\..\\IconImages\Back_MouseMove.png");
        }

        private void btn_Back_MouseLeave_1(object sender, EventArgs e)
        {
            btn_Back.BackgroundImage = Image.FromFile(@"..\\..\\IconImages\Back_MouseLeave.png");
        }
    }
}
