using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGame
{
    public partial class BrickGame : Form
    {
        public BrickGame()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        int ball_x = 12;
        int ball_y = 12;
        int score = 0;

        private void Game_Over()
        {
            if(score>23)
            {
                timer1.Stop();
                MessageBox.Show("You Win");
            }
            if(Ball.Top + Ball.Height > ClientSize.Height )
            {
                timer1.Stop();
                MessageBox.Show("Game Over");
            }
        }
        private void Get_Score()
        {
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && x.Tag == "block")
                {
                    if (Ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        Controls.Remove(x);
                        ball_y = -ball_y;
                        score++;
                        label1.Text = "Score: " + score;
                    }
                }
            }
        }
        private void Ball_movement()
        {
            Ball.Left += ball_x;
            Ball.Top += ball_y;

            if(Ball.Left + Ball.Width > ClientSize.Width || Ball.Left < 0)
            {
                ball_x = -ball_x;
            }

            if(Ball.Top < 0 || Ball.Bounds.IntersectsWith(player.Bounds))
            {
                ball_y = -ball_y;
            }

        }


        private void BrickGame_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left && player.Left > 0)
            {
                player.Left -= 100;
            }

            if (e.KeyCode == Keys.Right && player.Left < 740)
            {
                player.Left += 100;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Ball_movement();
            Get_Score();
            Game_Over();
        }
    }
}
