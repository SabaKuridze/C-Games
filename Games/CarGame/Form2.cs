using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace CarGame
{
    public partial class ShootingGame : Form
    {
        public ShootingGame()
        {
            InitializeComponent();
            EnemyJet1.BringToFront();
            EnemyJet2.BringToFront();
            EnemyJet3.BringToFront();
            Restart.BringToFront();
            Exist.BringToFront();
            MainJet.BringToFront();
        }

        private void ShootingGame_Load(object sender, EventArgs e)
        {
         //   string Wellcome = "Welcome to the jet game";
         //   SpeechSynthesizer synthesizer = new SpeechSynthesizer();
         //   synthesizer.SpeakAsync(Wellcome);
        }

        Random random = new Random();

        int x;
        int y = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            EnemyJet(JetSpeed);
            GameOverOver();
            ScoreCount();
        }

        Image image2 = Image.FromFile(@"D:\CarGame\CarGame\Resources\jet 32.png");
        void EnemyJet(int speed)
        {
            if(EnemyJet1.Top >= 700)
            {
                x = random.Next(50, 120);
                EnemyJet1.Location = new Point(x, y);
                EnemyJet1.Image = image2;
            }
            else
            {
                EnemyJet1.Top += speed;
            }

            if (EnemyJet2.Top >= 700)
            {
                x = random.Next(150, 230);
                EnemyJet2.Location = new Point(x, y);
                EnemyJet2.Image = image2;
            }
            else
            {
                EnemyJet2.Top += speed;
            }

            if (EnemyJet3.Top >= 700)
            {
                x = random.Next(270, 350);
                EnemyJet3.Location = new Point(x, y);
                EnemyJet3.Image = image2;
            }
            else
            {
                EnemyJet3.Top += speed;
            }

            if (pictureBox2.Top >= 700)
            {
                x = random.Next(30, 140);
                pictureBox2.Location = new Point(x, y);
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 700)
            {
                x = random.Next(160, 290);
                pictureBox3.Location = new Point(x, y);
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 700)
            {
                x = random.Next(310, 420);
                pictureBox4.Location = new Point(x, y);
            }
            else
            {
                pictureBox4.Top += speed;
            }
        }

        int bulletCount = 0;
        private void bullet1timer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Top -= 10;
        }

        Image image = Image.FromFile(@"D:\CarGame\CarGame\Resources\boom 2.png");
        void GameOverOver()
        {
           
            if (MainJet.Bounds.IntersectsWith(EnemyJet1.Bounds))
            {
                timer1.Enabled = false;
                Restart.Visible = true;
                Exist.Visible = true;
                MainJet.Image = image;
                BoomSound();
                GameOverSpeechSynthesizer();              
            }

            if (MainJet.Bounds.IntersectsWith(EnemyJet2.Bounds))
            {
                timer1.Enabled = false;
                Restart.Visible = true;
                Exist.Visible = true;
                MainJet.Image = image;
                BoomSound();
                GameOverSpeechSynthesizer();           
            }

            if (MainJet.Bounds.IntersectsWith(EnemyJet3.Bounds))
            {
                timer1.Enabled = false;
                Restart.Visible = true;
                Exist.Visible = true;
                MainJet.Image = image;
                BoomSound();
                GameOverSpeechSynthesizer();
            }
        }

        void BoomSound()
        {
          //  SoundPlayer boom = new SoundPlayer(@"C:\Users\sabaq\OneDrive\Desktop\Boom.wav");
          //  boom.Play();
        }

        void GameOverSpeechSynthesizer()
        {
           // string GameOverSpeech = "Game over, try again";
           // SpeechSynthesizer synthesizer2 = new SpeechSynthesizer();
           // synthesizer2.SpeakAsync(GameOverSpeech);
        }

        int JetSpeed = 2;
        int JetTurn = 20;
        int Score = 0;

        void ScoreCount()
        {
            if (pictureBox1.Bounds.IntersectsWith(EnemyJet1.Bounds))
            {
                EnemyJet1.Image = image;
                EnemyJet1.Location = new Point(-500, 0);
                BoomSound();
                AddScore();
            }

            if (pictureBox1.Bounds.IntersectsWith(EnemyJet2.Bounds))
            {
                EnemyJet2.Image = image;
                EnemyJet2.Location = new Point(-500, 0);
                BoomSound();
                AddScore();
            }

            if (pictureBox1.Bounds.IntersectsWith(EnemyJet3.Bounds))
            {
                EnemyJet3.Image = image;          
                EnemyJet3.Location = new Point(-500, 0);
                BoomSound();
                AddScore();
            }

        }

        void AddScore()
        {
            Score++;
            ScoreLabel.Text = "Score: " + Score.ToString();
            bullet1timer.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox1.Location = new Point(Q, E);
        }

        int Q = 211;
        int E = 542;  
        private void ShootingGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (JetSpeed < 20)
                {
                    JetSpeed++;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (JetSpeed > 0)
                {
                    JetSpeed--;
                }
            }

            if (e.KeyCode == Keys.Left)
            {
                if (MainJet.Left > 0)
                {
                    MainJet.Left += -JetTurn;
                    Q = Q - JetTurn;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                if (MainJet.Right < 430)
                {
                    MainJet.Left += JetTurn;
                    Q = Q + JetTurn;
                }
            }

            if(e.KeyCode == Keys.Space)
            {
                if (bulletCount % 1 == 0)
                {
                    pictureBox1.Location = new Point(Q, E);
                    bullet1timer.Enabled = true;
                    bulletCount++;
                }
            }
        }

        private void Exist_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Restart_Click_1(object sender, EventArgs e)
        {
            //Application.Restart();
            ShootingGame shootingGame = new ShootingGame();
            shootingGame.Show();
            Close();
        }

        private void bullet2timer_Tick(object sender, EventArgs e)
        {
            
        }

        private void MainJet_Click(object sender, EventArgs e)
        {

        }
        
    }
}
