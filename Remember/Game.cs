using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remember
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GameLogic.preGame == true || GameLogic.inGame == true)
            {
                GameLogic.StartTimer();
            }
            else
            {
                GameLogic.Restart(panel2);
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            label6.Text = GameLogic.playerName;
            GameLogic.GameSetUp(label8, label7, panel2);
            GameLogic.TimerSetUp(label2, button1);
            GameLogic.recieveLivesLabel(label8);
            GameLogic.recieveTilesLabel(label7);
        }
    }
}
