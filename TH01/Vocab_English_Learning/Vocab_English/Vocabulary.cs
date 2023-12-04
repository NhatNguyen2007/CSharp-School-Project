using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocab_English
{
    public partial class Vocabulary : Form
    {
        public Vocabulary()
        {
            InitializeComponent();
        }

        private void Vocabulary_Load(object sender, EventArgs e)
        {

        }

        private void animalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvw_Animals.Visible = true;
            lvw_Fruits.Visible = false;
            lvw_Vehicles.Visible = false;
        }

        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvw_Animals.Visible = false;
            lvw_Fruits.Visible = false;
            lvw_Vehicles.Visible = true;
        }

        private void fruitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvw_Animals.Visible = false;
            lvw_Fruits.Visible = true;
            lvw_Vehicles.Visible = false;
        }
    }
}
