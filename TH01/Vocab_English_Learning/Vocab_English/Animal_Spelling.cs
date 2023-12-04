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
    public partial class Animal_Spelling : Form
    {
        public Animal_Spelling()
        {
            InitializeComponent();
        }

        private int counter = 60;

        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList nodeList = null;

        public string pic = "", ans = "";

/*        public string pic1 = "", ans1 = "";
        public string pic2 = "", ans2 = "";
        public string pic3 = "", ans3 = "";
        public string pic4 = "", ans4 = "";
        public string pic5 = "", ans5 = "";*/

        public int question = 1;
        public int CorrectAnswers = 0;
        public int attempts = 3;
        public int points = 0;

        public Random rd = new Random();
        public int Numbrd = 0;
        public List<int> ListRand = new List<int>();
        public int[] MyArray;

        private void btn_Green_ComeBack_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Brown_ComeBack.BackColor = Color.Peru;
        }
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

        private void txt_Answer_Enter(object sender, EventArgs e)
        {
            RemoveText();
        }

        private void txt_Answer_Leave(object sender, EventArgs e)
        {
            AddText();
        }

        private void btn_Brown_ComeBack_MouseLeave(object sender, EventArgs e)
        {
            btn_Brown_ComeBack.BackColor = Color.Transparent;
        }

        private void btn_Brown_ComeBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void CorrectAnswer()
        {
            //txt_Answer.Enabled = false;
            txt_Answer.ForeColor = Color.White; txt_Answer.BackColor = Color.Green;

            question++;
            CorrectAnswers++;

            btn_Submit.Text = "Next Question";

            points += 2*attempts;

            lbl_Score.Text = points.ToString();
            
            ptr_Feedback.BackgroundImage = Image.FromFile(@"..\\..\\Images\Icons\Right.png"); ptr_Feedback.Visible = true;

/*            if (question == 6 && CorrectAnswers >= 3)
            {
                txt_Answer.Enabled = false;

                btn_Submit.Text = "Try another topic";
            }


            if (question == 6 && CorrectAnswers < 3)
            {
                txt_Answer.Enabled = false;

                btn_Submit.Text = "Try another topic";
            }*/

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
            txt_Answer.Enabled = true; txt_Answer.ForeColor = Color.Black; txt_Answer.BackColor = Color.White; 

            btn_Submit.Text = "SUBMIT";

            //lbl_CorrectAns.Visible = false;
            pnl_Board.Visible = false;
            pnl_Doggo.Visible = false;
            btn_Answer.Visible = false;

            lbl_QuestionNumb.Text = "Question number " + question;

            pic = nodeList[ListRand[question-1]].SelectSingleNode("Name").InnerText.Trim() + ".jpg";
            ans = nodeList[ListRand[question-1]].SelectSingleNode("Name").InnerText.Trim();

            picWord.BackgroundImage = Image.FromFile(@"..\\..\\Images\Animals\" + pic);
            lbl_Answer.Text = ans;

            ptr_Feedback.Visible = false;

            lbl_Attempts.Text = "3";
            attempts = 3;

            txt_Answer.Text = "Type your answer here...";
        }

        public void TryAgain()
        {
            txt_Answer.Enabled = true; txt_Answer.ForeColor = Color.Black; txt_Answer.BackColor = Color.White;
            txt_Answer.Text = "";
            txt_Answer.Focus();

            btn_Submit.Text = "SUBMIT";
            ptr_Feedback.Visible = false;
        }

        private void rjButton1_Click(object sender, EventArgs e)
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
            else if(btn_Submit.Text == "Next Question")
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

        public void GetRandom()
        {
            int i = 0;
            while(i<20)
            {
                Numbrd = rd.Next(0, nodeList.Count-1);
                if(ListRand.Contains(Numbrd)==false)
                {
                    ListRand.Add(Numbrd);
                    i++;
                }
            }
        }

        private void Animal_Spelling_Load(object sender, EventArgs e)
        {
            picbox_Try.WaitOnLoad = false;
            picbox_Try.LoadAsync(@"https://media.giphy.com/media/Bn6djQ6MgEWZi/giphy.gif");

            xmlDoc.Load(@"..\\..\\XML\Animals.xml");
            nodeList = xmlDoc.SelectNodes("/Animals" + "/Animal");

            StartLevel();
        }

        public void StartLevel()
        {
            GetRandom();
            pic = nodeList[ListRand[0]].SelectSingleNode("Name").InnerText.Trim() + ".jpg";
            ans = nodeList[ListRand[0]].SelectSingleNode("Name").InnerText.Trim();

            picWord.BackgroundImage = Image.FromFile(@"..\\..\\Images\Animals\" + pic);
            lbl_Answer.Text = ans;


            /* pic1 = nodeList[ListRand[0]].SelectSingleNode("Name").InnerText.Trim() + ".jpg";
             ans1 = nodeList[ListRand[0]].SelectSingleNode("Name").InnerText.Trim();

             picWord.BackgroundImage = Image.FromFile(@"..\\..\\Images\Animals\" + pic1);
             lbl_Answer.Text = ans1;

             pic2 = nodeList[ListRand[1]].SelectSingleNode("Name").InnerText.Trim() + ".jpg";
             ans2 = nodeList[ListRand[1]].SelectSingleNode("Name").InnerText.Trim();

             pic3 = nodeList[ListRand[2]].SelectSingleNode("Name").InnerText.Trim() + ".jpg";
             ans3 = nodeList[ListRand[2]].SelectSingleNode("Name").InnerText.Trim();

             pic4 = nodeList[ListRand[3]].SelectSingleNode("Name").InnerText.Trim() + ".jpg";
             ans4 = nodeList[ListRand[3]].SelectSingleNode("Name").InnerText.Trim();

             pic5 = nodeList[ListRand[4]].SelectSingleNode("Name").InnerText.Trim() + ".jpg";
             ans5 = nodeList[ListRand[4]].SelectSingleNode("Name").InnerText.Trim();*/

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
                rjButton1_Click(sender, e);
            }
        }

        public string GetScore
        {
            get { return lbl_Score.Text; }
        }
    }
}
