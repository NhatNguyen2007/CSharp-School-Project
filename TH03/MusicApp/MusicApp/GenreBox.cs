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
    public partial class GenreBox : UserControl
    {
        public GenreBox()
        {
            InitializeComponent();
        }

        public Image getset_GenreImg
        {
            get
            {
                return ptr_Genre.Image;
            }
            set
            {
                ptr_Genre.Image = value;
            }
        }

        public string getset_GenreName
        {
            get
            {
                return lbl_Genre.Text;
            }
            set
            {
                lbl_Genre.Text = value;
            }
        }

        public Color getset_ContainerColor
        {
            get
            {
                return pnl_Container.BackgroundColor;
            }
            set
            {
                pnl_Container.BackgroundColor = value;
            }
        }

        private void pnl_Container_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Genre_Interface(getset_GenreName), "Genre_Interface");
        }

        private void ptr_Genre_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Genre_Interface(getset_GenreName), "Genre_Interface");
        }

        private void lbl_Genre_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Genre_Interface(getset_GenreName), "Genre_Interface");
        }

        public void OpenChildForm(Form childForm, string currentform)
        {
            Search newform = (Search)this.Parent.Parent.Parent.Parent.Parent.Parent;

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
    }
}
