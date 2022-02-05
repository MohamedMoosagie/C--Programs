using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rockpaperscissors
{
    public partial class Form1 : Form
    {
        int rounds = 3;
        int timerPerRound = 6;
        bool gameover = false;

        public string[] CPUchoiceList = { "rock", "paper", "scissor", "paper", "scissor", "rock" };

       public int randomNumber = 0;
        Random rnd = new Random();

        string CPUchoice;
        string playerChoice;

        int playerscore;
        int  CPUscore;


        public Form1()
        {
            InitializeComponent();

            CountDownTimer.Enabled = true;

            playerChoice = "none";

            lblCountdown.Text = "5";
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            picPlayerIconBox.Image = Properties.Resources.rock;
            playerChoice = "rock";
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            picPlayerIconBox.Image = Properties.Resources.paper;
            playerChoice = "paper";
        }

        private void brnScissor_Click(object sender, EventArgs e)
        {
            picPlayerIconBox.Image = Properties.Resources.scissor;
            playerChoice = "scissor";
        }

        private void countDownTimerEvent(object sender, EventArgs e)
        {
            timerPerRound -= 1;
          
            lblCountdown.Text = timerPerRound.ToString();
           
            lblRoundNumber.Text = "Rounds: " + rounds;

            if(timerPerRound< 1)
            {
                CountDownTimer.Enabled = false;

                timerPerRound = 6;

                randomNumber = rnd.Next(0, CPUchoiceList.Length);

                CPUchoice = CPUchoiceList[randomNumber];

                switch(CPUchoice)
                {
                    case "rock":
                        picCpuIconBox.Image = Properties.Resources.rock;
                        break;

                    case "paper":
                        picCpuIconBox.Image = Properties.Resources.paper;
                        break;


                    case "scissor":
                        picCpuIconBox.Image = Properties.Resources.scissor;
                        break;


                }

                if(rounds > 0)
                {
                    checkGame();
                }
                else
                {
                    if (playerscore > CPUscore)
                    {
                        MessageBox.Show("player won the game");
                    }
                    else
                    {
                        MessageBox.Show("CPU won the game");
                    }
                    gameover = true;
                }
                StartNextRound();
            }

        }

        private void StartNextRound()
        {
            if (gameover == true)
            {
                return;
            }

            lblScore.Text = "player: " + playerscore + " - " + " CPU: " + CPUscore;
            playerChoice = "none";
            CountDownTimer.Enabled = true;
            picCpuIconBox.Image = Properties.Resources.question;
            picPlayerIconBox.Image = Properties.Resources.question;
        }

        private void checkGame()
        {
            if(playerChoice=="rock" && CPUchoice == "paper")
            {
                CPUscore += 1;
                rounds -= 1;

                MessageBox.Show("CPU wins , paper covers rock");
            }
            
            
            else if (playerChoice == "scissor" && CPUchoice == "rock")
            {
                CPUscore += 1;
                rounds -= 1;

                MessageBox.Show("CPU wins , rock breaks Scissors");
            }

            else if (playerChoice == "paper" && CPUchoice == "scissor")
            {
                CPUscore += 1;
                rounds -= 1;

                MessageBox.Show("CPU wins , Scissor cuts Paper");
            }

            else if (playerChoice == "scissor" && CPUchoice == "paper")
            {
                playerscore += 1;
                rounds -= 1;

                MessageBox.Show("Player wins , Scissor cuts Paper");
            }

            else if (playerChoice == "rock" && CPUchoice == "scissor")
            {
                playerscore += 1;
                rounds -= 1;

                MessageBox.Show("Player wins , rock crushes scissors");
            }
            else if (playerChoice == "paper" && CPUchoice == "rock")
            {
                playerscore += 1;
                rounds -= 1;

                MessageBox.Show("Player wins , paper covers rock");
            }
            else if (playerChoice == "none")
            {
           
                MessageBox.Show("enter a choice");
            }
            else
            {
                MessageBox.Show("Draw");
                nextRound();
            }

        }
private void nextRound()
    {
            playerChoice = "none";
            picPlayerIconBox.Image = Properties.Resources.question;
            CountDownTimer.Enabled = true;
            picCpuIconBox.Image = Properties.Resources.question;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            playerscore = 0;
            CPUscore = 0;
            rounds = 3;

            lblScore.Text = "player: " + playerscore + " - " + " CPU: " + CPUscore;
            playerChoice = "none";
            CountDownTimer.Enabled = true;
            picCpuIconBox.Image = Properties.Resources.question;
            picPlayerIconBox.Image = Properties.Resources.question;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
