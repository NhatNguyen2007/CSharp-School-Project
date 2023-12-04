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
    public partial class LeaderBoard : Form
    {
        public LeaderBoard()
        {
            InitializeComponent();
        }

        private void LeaderBoard_Load(object sender, EventArgs e)
        {
            lbl_Top1Score.Text = Convert.ToString(MainMenu.Top1Score);
            lbl_Top2Score.Text = Convert.ToString(MainMenu.Top2Score);
            lbl_Top3Score.Text = Convert.ToString(MainMenu.Top3Score);
            lbl_Top1Topic.Text = MainMenu.Topic1;
            lbl_Top2Topic.Text = MainMenu.Topic2;
            lbl_Top3Topic.Text = MainMenu.Topic3;
            if (lbl_Top1Topic.Text != "")
            {
                lbl_Name1.Text = "Player 1";
            }
            if (lbl_Top2Topic.Text != "")
            {
                lbl_Name2.Text = "Player 1";
            }
            if (lbl_Top3Topic.Text != "")
            {
                lbl_Name3.Text = "Player 1";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Brown_ComeBack_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Pink_ComeBack.BackColor = Color.LightPink;
        }

        private void btn_Pink_ComeBack_MouseLeave(object sender, EventArgs e)
        {
            btn_Pink_ComeBack.BackColor = Color.Transparent;
        }

        private void btn_Pink_ComeBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_unmute_Click(object sender, EventArgs e)
        {
            btn_unmute.Visible = false;
            btn_mute.Visible = true;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\\..\\Sound\sound.wav");
            player.Stop();
        }

        private void btn_mute_Click(object sender, EventArgs e)
        {
            btn_unmute.Visible = true;
            btn_mute.Visible = false;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\\..\\Sound\sound.wav");   
            player.PlayLooping();
        }
    }
}
