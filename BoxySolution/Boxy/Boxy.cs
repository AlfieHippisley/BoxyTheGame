using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boxy
{
    public partial class Boxy : Form
    {

        // Create a 2D array of buttons
        Button[,] btn = new Button[5, 5];

        public Boxy()
        {
            InitializeComponent();

            for (int x = 0; x < btn.GetLength(0); x++)
            {
                for (int y = 0; y < btn.GetLength(1); y++)
                {
                    btn[x, y] = new Button();
                    btn[x, y].SetBounds(55 * x, 55 * y, 45, 45);
                    btn[x, y].BackColor = Color.PowderBlue;
                    btn[x, y].Text = Convert.ToString(x + 1) + "," + (y + 1);
                    btn[x, y].Click += new EventHandler(this.btnEvent_Click);
                    GamePanel.Controls.Add(btn[x, y]);
                }
            }

        }

        void btnEvent_Click(object sender, EventArgs e)
        {
            Console.WriteLine(((Button)sender).Text);
        }

        // Purpose : This is the play menu button event handler
        private void PlayButton_Click(object sender, EventArgs e)
        {
            MainMenuPanel.SendToBack();
            GamePanel.BringToFront();
        }

        // Purpose : This is the learn menu button event handler
        private void LearnButton_Click(object sender, EventArgs e)
        {

        }

        // Purpose : This is the quit menu button event handler
        private void QuitButton_Click(object sender, EventArgs e)
        {
            quitConfirmation QF = new quitConfirmation();
            QF.ShowDialog();
        }

        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuBackground_Click(object sender, EventArgs e)
        {

        }
    }
}
