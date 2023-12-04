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
    public partial class Search : Form
    {
        public static Form currentChildForm;
        public static string currentForm = "";
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Default_Search_Interface(), "Default_Search_Interface");
        }

        public void OpenChildForm(Form childForm, string currentform)
        {
            Search newform = (Search)this;

            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            currentForm = currentform;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            newform.pnl_Container.Controls.Add(childForm);
            newform.pnl_Container.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                OpenChildForm(new Search_Interface(), "Search_Interface");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(txt_Search.Text == "" && currentForm == "Search_Interface")
            {
                OpenChildForm(new Default_Search_Interface(), "Default_Search_Interface");
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
