using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game
{
    public partial class Form1 : Form
    {

        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        int score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();

        bool goleft, goright;


        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left) goleft = true;
            
            
            if(e.KeyCode == Keys.Right) goright = true;

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goleft = false;

            if (e.KeyCode == Keys.Right) goright = false;


        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if(goleft == true && player.Left > 10) player.Left -= playerSpeed;

            if (goright == true && player.Left < 415) player.Left += playerSpeed;

            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

            if(roadTrack2.Top > 519) roadTrack2.Top = -519;

            if (roadTrack1.Top > 519) roadTrack1.Top = -519;
        }

        private void changeAIcars(PictureBox tempCar)
        {

        }

        private void gameOver()
        {

        }

        private void ResetGame()
        {
            buttonStart.Enabled = false;
            explosion.Visible = false;
            award.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            award.Image = Properties.Resources.bronze;

            roadSpeed = 12;
            trafficSpeed = 15;

            AI1.Top = carPosition.Next(200, 500) * -1;
            AI1.Left = carPosition.Next(5, 200);

            AI2.Top = carPosition.Next(200, 500) * -1;
            AI2.Left = carPosition.Next(245, 422);

            gameTimer.Start(); 
        }

        private void playSound()
        {

        }
    }
}
