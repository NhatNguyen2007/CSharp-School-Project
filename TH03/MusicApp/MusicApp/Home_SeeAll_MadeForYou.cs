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
    public partial class Home_SeeAll_MadeForYou : Form
    {
        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList nodeList = null;
        string songname = "";
        string artistname = "";

        public Random rd = new Random();
        public int Numbrd = 0;
        public List<int> ListRand = new List<int>();
        public Home_SeeAll_MadeForYou()
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

        private void Home_SeeAll_Load(object sender, EventArgs e)
        {
            xmlDoc.Load(@"..\\..\\XML\Songs.xml");
            nodeList = xmlDoc.SelectNodes("/Songs" + "/Song");

            GetRandom(nodeList.Count);

            for (int i = 0; i < nodeList.Count; i++)
            {
                songname = nodeList[ListRand[i]].SelectSingleNode("Name").InnerText.Trim();
                artistname = nodeList[ListRand[i]].SelectSingleNode("Artist").InnerText.Trim();
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

        private void btn_Like_Click(object sender, EventArgs e)
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
