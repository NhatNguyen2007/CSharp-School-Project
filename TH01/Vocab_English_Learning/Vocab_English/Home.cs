using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetSkin;
using System.Media;

namespace Vocab_English
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\\..\\Sound\sound.wav");
            player.PlayLooping();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {  

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Play_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Play.BackColor = Color.Pink;
        }

        private void btn_Play_MouseLeave(object sender, EventArgs e)
        {
            btn_Play.BackColor = Color.Transparent;
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MainMenu_Interface = new MainMenu();
            MainMenu_Interface.ShowDialog();
            this.Show();
        }

        private void btn_unmute_Click(object sender, EventArgs e)
        {
            btn_unmute.Visible = false;
            btn_mute.Visible = true;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\\..\\Sound\sound.wav");
            player.Stop();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            btn_unmute.Visible = true;
            btn_mute.Visible = false;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\\..\\Sound\sound.wav");
            player.PlayLooping();
        }
    }
}
