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
using System.Runtime.Remoting.Messaging;

namespace CarGame
{
    public partial class CarGame : Form
    {
        public CarGame()
        {
            InitializeComponent();
            Wall1.BringToFront();
            Wall2.BringToFront();
            Wall3.BringToFront();
            Restart.BringToFront();
            Exist.BringToFront();
        }

 
        private void CarGame_Load(object sender, EventArgs e)
        {
          // string Wellcome = "Welcome to the car game";
          // SpeechSynthesizer synthesizer = new SpeechSynthesizer();
          // synthesizer.SpeakAsync(Wellcome);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(CarSpeed);
            wall(CarSpeed);
            GameOverOver();
            Money(CarSpeed);
            MoneyCollection();
        }


        Random random = new Random();

        int x;
        int y = 0;

        void wall(int speed)
        {
            if (Wall1.Top >= 730)
            {
                x = random.Next(50, 120);
                Wall1.Location = new Point(x, y); 
            }
            else
            {
                Wall1.Top += speed;
            }

            if (Wall2.Top >= 730)
            {
                x = random.Next(160, 230);
                Wall2.Location = new Point(x, y);
            }
            else
            {
                Wall2.Top += speed;
            }

            if (Wall3.Top >= 730)
            {
                x = random.Next(270, 350);
                Wall3.Location = new Point(x, y);
            }
            else
            {
                Wall3.Top += speed;
            }
        }

        void Money(int speed)
        {
            if (Money1.Top >= 730)
            {
                x = random.Next(70, 140);
                Money1.Location = new Point(x, y);
            }
            else
            {
                Money1.Top += speed;
            }

            if (Money2.Top >= 730)
            {
                x = random.Next(190, 260);
                Money2.Location = new Point(x, y);
            }
            else
            {
                Money2.Top += speed;
            }

            if (Money3.Top >= 730)
            {
                x = random.Next(310, 380);
                Money3.Location = new Point(x, y);
            }
            else
            {
                Money3.Top += speed;
            }
        }

        void GameOverOver()
        {
            if (Car.Bounds.IntersectsWith(Wall1.Bounds))
            {
                ChangeVisible();
                CrashSound();
                GameOverSynthesizer();
            }

            if (Car.Bounds.IntersectsWith(Wall2.Bounds))
            {
                ChangeVisible();
                CrashSound();
                GameOverSynthesizer();
            }

            if (Car.Bounds.IntersectsWith(Wall3.Bounds))
            {
                ChangeVisible();
                CrashSound();
                GameOverSynthesizer();
            }
        }

        
        void CrashSound()
        {
           // SoundPlayer crash = new SoundPlayer(@"C:\Users\sabaq\OneDrive\Desktop\crash3.wav");
           // crash.Play();
        }

        void GameOverSynthesizer()
        {
          //  string GameOverSpeech = "Game over, try again";
          //  SpeechSynthesizer synthesizer2 = new SpeechSynthesizer();
          //  synthesizer2.SpeakAsync(GameOverSpeech);
        }

        void ChangeVisible()
        {
            timer1.Enabled = false;
            Restart.Visible = true;
            Exist.Visible = true;
        }

       
        void moveline(int speed)
        {
            if (pictureBox1.Top >= 730)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 730)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 730)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox5.Top >= 730)
            {
                pictureBox5.Top = 0;
            }
            else
            {
                pictureBox5.Top += speed;
            }

            if (pictureBox4.Top >= 730)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

            if (pictureBox8.Top >= 730)
            {
                pictureBox8.Top = 0;
            }
            else
            {
                pictureBox8.Top += speed;
            }

            if (pictureBox9.Top >= 730)
            {
                pictureBox9.Top = 0;
            }
            else
            {
                pictureBox9.Top += speed;
            }

            if (pictureBox10.Top >= 730)
            {
                pictureBox10.Top = 0;
            }
            else
            {
                pictureBox10.Top += speed;
            }

            if (pictureBox11.Top >= 730)
            {
                pictureBox11.Top = 0;
            }
            else
            {
                pictureBox11.Top += speed;
            }
        }

        int CollectedMoney = 0;
        int CarSpeed = 2;
        int CarTurn = 30;

        void MoneyCollection()
        {
            if (Car.Bounds.IntersectsWith(Money1.Bounds))
            {
                AddCash();
                x = random.Next(25, 150);
                Money1.Location = new Point(x, y);
            }

            if (Car.Bounds.IntersectsWith(Money2.Bounds))
            {
                AddCash();
                x = random.Next(125, 250);
                Money2.Location = new Point(x, y);
            }

            if (Car.Bounds.IntersectsWith(Money3.Bounds))
            {
                AddCash();
                x = random.Next(250, 375);
                Money3.Location = new Point(x, y);
            }
        }

        void AddCash()
        {
            CollectedMoney++;
            label1.Text = "Money: " + CollectedMoney.ToString();
        }
        private void Car_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void CarGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (CarSpeed < 30)
                {
                    CarSpeed++;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (CarSpeed > 0)
                {
                    CarSpeed--;
                }
            }

            if (e.KeyCode == Keys.Left)
            {
                if (Car.Left > 0)
                {
                    Car.Left += -CarTurn;
                }
            }

            if (e.KeyCode == Keys.Right)
            {

                if (Car.Right < 380)
                {
                    Car.Left += CarTurn;
                }
            }

            if (e.KeyCode == Keys.Space && CarSpeed == 0)
            {
                    Image SaveImage = Car.Image;
                    Car.Image = SecondCar.Image;
                    SecondCar.Image = SaveImage;
            }
            
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            CarGame Game1 = new CarGame();
            Game1.Show();
            Close();
        }

        private void Exist_Click(object sender, EventArgs e)
        {
            Close();
        }

        
       
    }
}
