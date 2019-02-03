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
    public partial class quitConfirmation : Form
    {
        public quitConfirmation()
        {
            InitializeComponent();
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            //exits full program
            Application.Exit();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            //Closes the confirmation window
            this.Close();
        }
    }
}
