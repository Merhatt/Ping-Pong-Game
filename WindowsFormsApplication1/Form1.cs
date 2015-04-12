using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Game : Form
    {
        
        bool esc = false;   //Is Escape is pressed
        int speed = 6;     //Speed of the players
        float speedNow = 0.2f;   //Ball speed per second
        int win = 0;    //Who win        
        int p1Wins = 0;
        bool noSuprise = true;
        int p2Wins = 0;
        bool p1Down;
        float ballUpSpeed = 2f;
        float ballLeftSpeed = 2f;
        bool p2Down;
        bool p1Up;
        bool p2Up;

        

        public Game()
        {
            InitializeComponent();
            // Cursor.Hide();
            // FormBorderStyle = FormBorderStyle.None;
            ball.BorderStyle = BorderStyle.None;
            //TopMost = true;

            NewGame.Visible = true;
            Exit.Visible = true;
            Player1.Visible = false;
            Player2.Visible = false;
            ball.Visible = false;
            label1.Visible = false;
            timer1.Interval = 9999999;
            //this.Bounds = Screen.PrimaryScreen.Bounds;
            //ball.Top = PlayGround.Bottom - (PlayGround.Bottom / 10);
            Bonus.Visible = false;



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

          


            timer1.Interval = 1;
            if (p1Up)
            {
                if (Player1.Top >= Top.Top + 20)
                {
                    Player1.Top -= speed;
                }
            }

            if (p2Up)
            {
                if (Player2.Top >= Top.Top + 20)
                {
                    Player2.Top -= speed;
                }
            }
            if (p1Down)
            {
                if (Player1.Bottom <= Bot.Bottom - 15)
                {
                    Player1.Top += speed;
                }
            }
            if (p2Down)
            {
                if (Player2.Bottom <= Bot.Bottom - 15)
                {
                    Player2.Top += speed;
                }
            }
            if (ball.Top <= Top.Top + 25)
            {
                ballUpSpeed = -2f - speedNow ;
                ball.BackColor = Color.Cyan;
            }
            if (ball.Bottom >= Bot.Bottom - 15)
            {
                ballUpSpeed = 2f +speedNow;
                ball.BackColor = Color.Red;
            }
            if (Player2.Location.X + 15 >= ball.Location.X && ball.Location.Y >= Player2.Location.Y && ball.Location.Y <= Player2.Location.Y + 71)
            {
                ballLeftSpeed = -2f - speedNow;
                speedNow += 0.3f;
                ball.BackColor = Color.GreenYellow;
            }
            if (Player1.Location.X - 15 <= ball.Location.X && ball.Location.Y >= Player1.Location.Y && ball.Location.Y <= Player1.Location.Y + 71)
            {
                ballLeftSpeed = 2f + speedNow;
                ball.BackColor = Color.Gold;
                speedNow += 0.3f;
            }
           //Dynamic Move
           // if (Player2.Location.X + 15 >= ball.Location.X && ball.Location.Y >= Player2.Location.Y && ball.Location.Y <= Player2.Location.Y + 20)
           // {
           //     ballLeftSpeed = -2f ;
           //     ballUpSpeed += speedNow;
           //     speedNow += 0.3f;
           //     ball.BackColor = Color.GreenYellow;
           // }

            if (Player2.Location.X >= ball.Location.X + 10)
            {
                win = 1;
            }
            if (Player1.Location.X <= ball.Location.X - 10)
            {
                win = 2;
            }
            ball.Top -= (int)ballUpSpeed;
            ball.Left -= (int)ballLeftSpeed;
            if (win > 0)
            {

                speedNow = 0.2f;
                ballLeftSpeed = 2f + speedNow; 
                timer1.Interval = 1000;
                if (win == 1)
                {
                    p1Wins++;
                }
                if (win == 2)
                {
                    p2Wins++;
                }
                label1.Text = "Player 1: " + p1Wins + "      Player 2: " + p2Wins;
                ball.Top = PlayGround.Bottom / 2;
                ball.Left = PlayGround.Right / 2;
                win = 0;
        
                if (p2Wins == 3)
                {

                    timer1.Interval = 999999;
                    label1.Visible = false;
                    NewGame.Visible = true;
                    Player1.Visible = false;
                    Player2.Visible = false;
                    ball.Visible = false;
                    Exit.Visible = true;
                    speedNow = 0.2f;
                }
                if (p1Wins == 3)
                {

                    label1.Visible = false;
                    NewGame.Visible = true;
                    Player1.Visible = false;
                    Player2.Visible = false;
                    ball.Visible = false;
                    Exit.Visible = true;
                    timer1.Interval = 999999;
                    speedNow = 0.2f;
                }

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                p1Down = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                p1Up = true;
            }
            if (e.KeyCode == Keys.S)
            {
                p2Down = true;
            }
            if (e.KeyCode == Keys.W)
            {
                p2Up = true;
            }
            if (e.KeyCode == Keys.Escape && esc == false)
            {

                label1.Visible = false;
                NewGame.Visible = true;
                Player1.Visible = false;
                Player2.Visible = false;
                ball.Visible = false;
                Exit.Visible = true;
                Continue.Visible = true;
                timer1.Interval = 999999;
                Pause.Visible = true;
                esc = true;




            }
            else
            {
                label1.Visible = true;
                NewGame.Visible = false;
                Player1.Visible = true;
                Player2.Visible = true;
                ball.Visible = true;
                Exit.Visible = false;
                Continue.Visible = false;
                timer1.Interval = 1;
                Pause.Visible = false;
                esc = false;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                p1Up = false;
            }
            if (e.KeyCode == Keys.W)
            {
                p2Up = false;
            }
            if (e.KeyCode == Keys.S)
            {
                p2Down = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                p1Down = false;
            }
        }

        private void ball_Click(object sender, EventArgs e)
        {

        }

        private void PlayGround_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            


        }

        private void NewGame_MouseEnter(object sender, EventArgs e)
        {
            
            
        }

        private void NewGame_MouseDown(object sender, MouseEventArgs e)
        {
            p1Wins = 0;
            p2Wins = 0;
            NewGame.Visible = false;
            label1.Visible = true;
            Continue.Visible = false;
            Player1.Visible = true;
            Player2.Visible = true;
            ball.Visible = true;
            label1.Text = "Player 1: " + p1Wins + "      Player 2: " + p2Wins;
            ball.Top = PlayGround.Bottom / 2;
            ball.Left = PlayGround.Right / 2;
            timer1.Interval = 1;
            speedNow = 0.2f;
            Exit.Visible = false;
            ballLeftSpeed = 2f + speedNow;
            Pause.Visible = false;
        }

       

        private void PlayGround_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Exit_MouseDown_1(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void NewGame_Click_1(object sender, EventArgs e)
        {

        }

        private void Continue_Click(object sender, EventArgs e)
        {

        }

        private void Continue_MouseDown(object sender, MouseEventArgs e)
        {
                label1.Visible = true;
                NewGame.Visible = false;
                Player1.Visible = true;
                Player2.Visible = true;
                ball.Visible = true;
                Exit.Visible = false;
                Continue.Visible = false;
                timer1.Interval = 1;
                Pause.Visible = false;
               
        }

        
    }
}
