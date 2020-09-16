using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace CarGame
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarGame Game1 = new CarGame();
            Game1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShootingGame shootingGame = new ShootingGame();
            shootingGame.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Options Options = new Options();
            Options.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BrickGame brickgame = new BrickGame();
            brickgame.ShowDialog();
        }
    }
}
