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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public static string Topic = "";
        public static string Topic1 = "";
        public static string Topic2 = "";
        public static string Topic3 = "";
        public static int Top1Score = 0;
        public static int Top2Score = 0;
        public static int Top3Score = 0;

        public int Animal_spellingPoints = 0;
        public int Vehicle_spellingPoints = 0;
        public int Fruit_spellingPoints = 0;
        public LeaderBoard LeaderBoard_interface = new LeaderBoard();

        public void Ranking(int p)
        {
            if (Top2Score < p)
            {
                if (Top1Score <= p)
                {
                    Top3Score = Top2Score;
                    Top2Score = Top1Score;
                    Top1Score = p;

                    Topic3 = Topic2;
                    Topic2 = Topic1;
                    Topic1 = Topic;
                }
                else
                {
                    Top3Score = Top2Score;
                    Top2Score = p;

                    Topic3 = Topic2;
                    Topic2 = Topic;
                }

            }
            else if (Top2Score > p)
            {
                if (Top3Score < p)
                {
                    Top3Score = p;

                    Topic3 = Topic;
                }
            }
            else if (Top2Score == p)
            {
                Top3Score = Top2Score;
                Top2Score = p;

                Topic3 = Topic2;
                Topic2 = Topic;
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Animal_Spelling Animal_Interface = new Animal_Spelling();
            //Animal_Interface.ShowDialog();
            using(Animal_Spelling Animal_Interface = new Animal_Spelling())
            {
                if (Animal_Interface.ShowDialog() == DialogResult.OK)
                {
                    int p = Convert.ToInt32(Animal_Interface.GetScore);
                    Animal_spellingPoints += p;
                    lbl_AnimalScore.Text = Convert.ToString(Animal_spellingPoints);

                    Topic = "Animals";

                    Ranking(p);
                }
            }
            this.Show();
        }

        private void btn_Vehicles_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Vehicle_Spelling Vehicle_Interface = new Vehicle_Spelling())
            {
                if (Vehicle_Interface.ShowDialog() == DialogResult.OK)
                {
                    int p = Convert.ToInt32(Vehicle_Interface.GetScore);
                    Vehicle_spellingPoints += p;
                    lbl_VehicleScore.Text = Convert.ToString(Vehicle_spellingPoints);

                    Topic = "Vehicles";

                    Ranking(p);
                }
            }
            this.Show();
        }

        private void btn_Fruits_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Fruit_Spelling Fruit_Interface = new Fruit_Spelling())
            {
                if (Fruit_Interface.ShowDialog() == DialogResult.OK)
                {
                    int p = Convert.ToInt32(Fruit_Interface.GetScore);
                    Fruit_spellingPoints += p;
                    lbl_FruitScore.Text = Convert.ToString(Fruit_spellingPoints);

                    Topic = "Fruits";

                    Ranking(p);
                }
            }
            this.Show();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_HighScore_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaderBoard_interface.ShowDialog();
            this.Show();
        }

        private void btn_Lesson_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vocabulary Vocab_interface = new Vocabulary();
            Vocab_interface.ShowDialog();
            this.Show();
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
