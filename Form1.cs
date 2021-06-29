using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace KinoRejestracja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void newWindow(string time)
        {
            this.Hide();
            var form2 = new Form2(time);
            form2.ShowDialog();
        }

        private void buttonTimeFight2_Click(object sender, EventArgs e)
        {
            newWindow("bilet na film " + "Mortal Wombat" + " o godzinie " + buttonTimeFight2.Text);
        }

        private void buttonTimeFight1_Click(object sender, EventArgs e)
        {
            newWindow("bilet na film " + "Mortal Wombat" + " o godzinie " + buttonTimeFight1.Text);
        }

        private void buttonTimeCruella2_Click(object sender, EventArgs e)
        {

            newWindow("bilet na film " + "Cruella" + " o godzinie " + buttonTimeCruella2.Text);
        }

        private void buttonTimeCruella1_Click(object sender, EventArgs e)
        {
            newWindow("bilet na film " + "Cruella"+ " o godzinie " + buttonTimeCruella1.Text);
        }

        private void buttonTimeGodzilla2_Click(object sender, EventArgs e)
        {
            newWindow("bilet na film "+ "Godzilla vs Goryl" + " o godzinie " + buttonTimeGodzilla2.Text);
        }

        private void buttonTimeGodzilla1_Click(object sender, EventArgs e)
        {
            newWindow("bilet na film " + "Godzilla vs Goryl" + " o godzinie " +buttonTimeGodzilla1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
