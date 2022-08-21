using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace igra1
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HappyBirrd_Click(object sender, EventArgs e)
        {   
            
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            HappyBirrd.Top += gravity;
            pipeBotton.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score:" + score ;
            
            if (pipeBotton.Left<-150)
            {
                pipeBotton.Left = 800;
                score++;
            }
            if (pipeTop.Left<-180)
            {
                pipeTop.Left = 950;
                score++;
            }
            if (HappyBirrd.Bounds.IntersectsWith(pipeBotton.Bounds) || HappyBirrd.Bounds.IntersectsWith(pipeTop.Bounds) || HappyBirrd.Bounds.IntersectsWith(ground.Bounds) || (HappyBirrd.Top < -25))
            {
                endGame();
            }
            if (score> 5)
            {
                pipeSpeed = 15;
            }
            
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }


        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += "  Game over!!!";
        }

    }


}
