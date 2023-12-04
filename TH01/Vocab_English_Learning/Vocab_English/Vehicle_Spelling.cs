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

namespace Vocab_English
{
    public partial class Vehicle_Spelling : Form
    {
        public Vehicle_Spelling()
        {
            InitializeComponent();
        }

        private int counter = 60;

        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList nodeList = null;

        public string pic = "", ans = "";

        public int question = 1;
        public int CorrectAnswers = 0;
        public int attempts = 3;
        public int points = 0;

        public Random rd = new Random();
        public int Numbrd = 0;
        public List<int> ListRand = new List<int>();
        public int[] MyArray;

        public void RemoveText()
        {
            if (txt_Answer.Text == "Type your answer here..." || txt_Answer.Text == "Please type an answer first!")
            {
                txt_Answer.Text = "";
                txt_Answer.ForeColor = Color.Black;
                ptr_Feedback.Visible = false;
            }
        }

        public void AddText()
        {
            if (String.IsNullOrWhiteSpace(txt_Answer.Text))
            {
                txt_Answer.Text = "Type your answer here...";
            }
        }

        private void btn_ComeBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Green_ComeBack_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Green_ComeBack.BackColor = Color.LightSeaGreen;
        }

        private void btn_Green_ComeBack_MouseLeave(object sender, EventArgs e)
        {
            btn_Green_ComeBack.BackColor = Color.Transparent;
        }

        public void CorrectAnswer()
        {
            //txt_Answer.Enabled = false;
            txt_Answer.ForeColor = Color.White; txt_Answer.BackColor = Color.Green;

            question++;
            CorrectAnswers++;

            btn_Submit.Text = "Next Question";

            points += 2 * attempts;

            lbl_Score.Text = points.ToString();

            ptr_Feedback.BackgroundImage = Image.FromFile(@"..\\..\\Images\Icons\Right.png"); ptr_Feedback.Visible = true;

        }

        public void IncorrectAnswer()
        {
            //txt_Answer.Enabled = false;
            txt_Answer.ForeColor = Color.White; txt_Answer.BackColor = Color.Red;

            attempts--;
            lbl_Attempts.Text = attempts.ToString();

            if (attempts == 0)
            {
                //txt_Answer.Enabled = false;

                ptr_Feedback.BackgroundImage = Image.FromFile(@"..\\..\\Images\Icons\Wrong.png"); ptr_Feedback.Visible = true;

                question++;


                //lbl_CorrectAns.Text = "The correct answer is "; lbl_CorrectAns.Visible = true;
                pnl_Board.Visible = true;
                pnl_Doggo.Visible = true;
                btn_Answer.Text = lbl_Answer.Text; btn_Answer.Visible = true;

                btn_Submit.Text = "Next Question";
            }
            else
            {
                if (attempts == 2)
                {
                    ptr_Feedback.BackgroundImage = Image.FromFile(@"..\\..\\Images\Icons\Wrong.png");
                }
                else if (attempts == 1)
                {
                    ptr_Feedback.BackgroundImage = Image.FromFile(@"..\\..\\Images\Icons\Wrong.png");
                }

                ptr_Feedback.Visible = true;

                btn_Submit.Text = "Try Again";
                btn_Submit.Focus();
            }
        }

        public void CheckYourAnswer()
        {
            if (txt_Answer.Text.Trim().ToLower() == lbl_Answer.Text.Trim().ToLower())
            {
                CorrectAnswer();
            }
            else
            {
                IncorrectAnswer();
            }
        }

        public void NextQuestion()
        {
            txt_Answer.Enabled = true;
            txt_Answer.ForeColor = Color.Black; txt_Answer.BackColor = Color.White;

            btn_Submit.Text = "SUBMIT";

            //lbl_CorrectAns.Visible = false;
            pnl_Board.Visible = false;
            pnl_Doggo.Visible = false;
            btn_Answer.Visible = false;

            lbl_QuestionNumb.Text = "Question number " + question;

            pic = nodeList[ListRand[question - 1]].SelectSingleNode("Name").InnerText.Trim() + ".jpg";
            ans = nodeList[ListRand[question - 1]].SelectSingleNode("Name").InnerText.Trim();

            picWord.BackgroundImage = Image.FromFile(@"..\\..\\Images\Vehicles\" + pic);
            lbl_Answer.Text = ans;

            ptr_Feedback.Visible = false;

            lbl_Attempts.Text = "3";
            attempts = 3;

            txt_Answer.Text = "Type your answer here...";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (btn_Submit.Text == "Try another topic")
            {
                this.DialogResult = DialogResult.OK;
            }
            else if (txt_Answer.Text.Trim() == "" || txt_Answer.Text.Trim() == "Type your answer here..." || txt_Answer.Text.Trim() == "Please type an answer first!")
            {
                txt_Answer.ForeColor = Color.Red;
                txt_Answer.Text = "Please type an answer first!";
                ptr_Feedback.BackgroundImage = Image.FromFile(@"..\\..\\Images\Icons\Alert.png"); ptr_Feedback.Visible = true;
            }
            else if (btn_Submit.Text == "Next Question")
            {
                btn_Submit.Focus();
                NextQuestion();
                txt_Answer.Focus();
            }
            else if (btn_Submit.Text == "Try Again")
            {
                TryAgain();
            }
            else if (btn_Submit.Text == "SUBMIT")
            {
                CheckYourAnswer();
            }
        }

        public void TryAgain()
        {
            txt_Answer.Enabled = true; txt_Answer.ForeColor = Color.Black; txt_Answer.BackColor = Color.White;
            txt_Answer.Text = "";
            txt_Answer.Focus();

            btn_Submit.Text = "SUBMIT";
            ptr_Feedback.Visible = false;
        }

        private void Vehicle_Spelling_Load(object sender, EventArgs e)
        {
            picbox_Try.WaitOnLoad = false;
            picbox_Try.LoadAsync(@"https://media.giphy.com/media/Bn6djQ6MgEWZi/giphy.gif");

            xmlDoc.Load(@"..\\..\\XML\Vehicles.xml");
            nodeList = xmlDoc.SelectNodes("/Vehicles" + "/Vehicle");

            StartLevel();
        }

        public void StartLevel()
        {
            GetRandom();
            pic = nodeList[ListRand[0]].SelectSingleNode("Name").InnerText.Trim() + ".jpg";
            ans = nodeList[ListRand[0]].SelectSingleNode("Name").InnerText.Trim();

            picWord.BackgroundImage = Image.FromFile(@"..\\..\\Images\Vehicles\" + pic);
            lbl_Answer.Text = ans;

            lbl_QuestionNumb.Text = "Question number " + question;

            txt_Answer.Enabled = true;
            txt_Answer.Text = "Type your answer here...";

            //lbl_CorrectAns.Visible = false;


            counter = 60;
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            lbl_Time.Text = counter.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();
                txt_Answer.Enabled = false;
                lbl_TimeOut.Visible = true;
                btn_Submit.Text = "Try another topic";
            }
            lbl_Time.Text = counter.ToString();
        }

        public void GetRandom()
        {
            int i = 0;
            while (i < 20)
            {
                Numbrd = rd.Next(0, nodeList.Count - 1);
                if (ListRand.Contains(Numbrd) == false)
                {
                    ListRand.Add(Numbrd);
                    i++;
                }
            }
        }

        private void txt_Answer_Enter_1(object sender, EventArgs e)
        {
            RemoveText();
        }

        private void txt_Answer_Leave(object sender, EventArgs e)
        {
            AddText();
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

        private void txt_Answer_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_Submit_Click(sender, e);
            }
        }

        public string GetScore
        {
            get { return lbl_Score.Text; }
        }
    }
}
