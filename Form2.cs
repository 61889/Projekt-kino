using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinoRejestracja
{
    public partial class Form2 : Form
    {
        string time;
        int ileMiejsc = 0;
        string places = "";
        public Form2(string time)
        {
            this.time = time;
            InitializeComponent();
        }

        int funnyButtons()
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.BackColor == Color.Gold)
                {
                    button.Enabled = false;
                    button.BackColor = Color.Red;
                    places += "miejsce fotelu oraz rzad:" + button.Text + ";";
                    ileMiejsc++;
                }
            }
            return ileMiejsc;
        }
        public int funnyButtonsTest()
        {
            int ileMiejscc = 0;
            string placess = "";
            button1.BackColor = Color.Gold;
            button2.BackColor = Color.Gold;
            button3.BackColor = Color.Gold;
            button4.BackColor = Color.Gold;
                if (button1.BackColor == Color.Gold)
                {
                    button1.Enabled = false;
                    button1.BackColor = Color.Red;
                    placess += "miejsce fotelu oraz rzad:" + button1.Text + ";";
                    ileMiejscc++;
                }
                if (button2.BackColor == Color.Gold)
                {
                    button2.Enabled = false;
                    button2.BackColor = Color.Red;
                    placess += "miejsce fotelu oraz rzad:" + button2.Text + ";";
                    ileMiejscc++;
                }
                if (button3.BackColor == Color.Gold)
                {
                    button3.Enabled = false;
                    button3.BackColor = Color.Red;
                    placess += "miejsce fotelu oraz rzad:" + button3.Text + ";";
                    ileMiejscc++;
                }
                if (button4.BackColor == Color.Gold)
                {
                    button4.Enabled = false;
                    button4.BackColor = Color.Red;
                    placess += "miejsce fotelu oraz rzad:" + button4.Text + ";";
                    ileMiejscc++;
                }
            return ileMiejscc;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (button26.BackColor == Color.Lime)
             
            {
                button26.BackColor = Color.Gold;
            }
            else
            {
                button26.BackColor = Color.Lime;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (button25.BackColor == Color.Lime)
             
            {
                button25.BackColor = Color.Gold;
            }
            else
            {
                button25.BackColor = Color.Lime;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == Color.Lime)
             
            {
                button10.BackColor = Color.Gold;
            }
            else
            {
                button10.BackColor = Color.Lime;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == Color.Lime)
             
            {
                button11.BackColor = Color.Gold;
            }
            else
            {
                button11.BackColor = Color.Lime;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == Color.Lime)
             
            {
                button12.BackColor = Color.Gold;
            }
            else
            {
                button12.BackColor = Color.Lime;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor == Color.Lime)
             
            {
                button13.BackColor = Color.Gold;
            }
            else
            {
                button13.BackColor = Color.Lime;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor == Color.Lime)
             
            {
                button14.BackColor = Color.Gold;
            }
            else
            {
                button14.BackColor = Color.Lime;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor == Color.Lime)
             
            {
                button15.BackColor = Color.Gold;
            }
            else
            {
                button15.BackColor = Color.Lime;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button21.BackColor == Color.Lime)
             
            {
                button21.BackColor = Color.Gold;
            }
            else
            {
                button21.BackColor = Color.Lime;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button22.BackColor == Color.Lime)
             
            {
                button22.BackColor = Color.Gold;
            }
            else
            {
                button22.BackColor = Color.Lime;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button24.BackColor == Color.Lime)
             
            {
                button24.BackColor = Color.Gold;
            }
            else
            {
                button24.BackColor = Color.Lime;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.Lime)
             
            {
                button4.BackColor = Color.Gold;
            }
            else
            {
                button4.BackColor = Color.Lime;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.Lime)
             
            {
                button5.BackColor = Color.Gold;
            }
            else
            {
                button5.BackColor = Color.Lime;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.Lime)
             
            {
                button6.BackColor = Color.Gold;
            }
            else
            {
                button6.BackColor = Color.Lime;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.Lime)
             
            {
                button7.BackColor = Color.Gold;
            }
            else
            {
                button7.BackColor = Color.Lime;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.Lime)
             
            {
                button8.BackColor = Color.Gold;
            }
            else
            {
                button8.BackColor = Color.Lime;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.Lime)
             
            {
                button9.BackColor = Color.Gold;
            }
            else
            {
                button9.BackColor = Color.Lime;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.BackColor == Color.Lime)
             
            {
                button16.BackColor = Color.Gold;
            }
            else
            {
                button16.BackColor = Color.Lime;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.BackColor == Color.Lime)
             
            {
                button17.BackColor = Color.Gold;
            }
            else
            {
                button17.BackColor = Color.Lime;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if ( button20.BackColor == Color.Lime)
             
            {
                button20.BackColor = Color.Gold;
            }
            else
            {
                button20.BackColor = Color.Lime;
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (button39.BackColor == Color.Lime)
            {
                button39.BackColor = Color.Gold;            
            }
            else
            {
            button39.BackColor = Color.Lime;
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (button40.BackColor == Color.Lime)
            {
                button40.BackColor = Color.Gold;
            }
            else
            {
                button40.BackColor = Color.Lime;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (button41.BackColor == Color.Lime)
            {
                button41.BackColor = Color.Gold;
            }
            else
            {
                button41.BackColor = Color.Lime;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (button42.BackColor == Color.Lime)
            {
                button42.BackColor = Color.Gold;
            }
            else
            {
                button42.BackColor = Color.Lime;
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (button43.BackColor == Color.Lime)
            {
                button43.BackColor = Color.Gold;
            }
            else
            {
                button43.BackColor = Color.Lime;
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (button44.BackColor == Color.Lime)
            {
                button44.BackColor = Color.Gold;
            }
            else
            {
                button44.BackColor = Color.Lime;
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (button45.BackColor == Color.Lime)
            {
                button45.BackColor = Color.Gold;
            }
            else
            {
                button45.BackColor = Color.Lime;
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (button46.BackColor == Color.Lime)
            {
                button46.BackColor = Color.Gold;
            }
            else
            {
                button46.BackColor = Color.Lime;
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (button47.BackColor == Color.Lime)
            {
                button47.BackColor = Color.Gold;
            }
            else
            {
                button47.BackColor = Color.Lime;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (button35.BackColor == Color.Lime)
            {
                button35.BackColor = Color.Gold;
            }
            else
            {
                button35.BackColor = Color.Lime;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (button31.BackColor == Color.Lime)
            {
                button31.BackColor = Color.Gold;
            }
            else
            {
                button31.BackColor = Color.Lime;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (button27.BackColor == Color.Lime)
            {
                button27.BackColor = Color.Gold;
            }
            else
            {
                button27.BackColor = Color.Lime;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (button23.BackColor == Color.Lime)
            {
                button23.BackColor = Color.Gold;
            }
            else
            {
                button23.BackColor = Color.Lime;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.BackColor == Color.Lime)
            {
                button19.BackColor = Color.Gold;
            }
            else
            {
                button19.BackColor = Color.Lime;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.BackColor == Color.Lime)
            {
                button18.BackColor = Color.Gold;
            }
            else
            {
                button18.BackColor = Color.Lime;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Lime)
            {
                button3.BackColor = Color.Gold;
            }
            else
            {
                button3.BackColor = Color.Lime;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Lime)
            {
                button2.BackColor = Color.Gold;
            }
            else
            {
                button2.BackColor = Color.Lime;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Lime)
            {
                button1.BackColor = Color.Gold;
            }
            else
            {
                button1.BackColor = Color.Lime;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            funnyButtons();
            var form3 = new Platnosc(places, time, ileMiejsc);
            form3.ShowDialog();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonEkran_Click(object sender, EventArgs e)
        {

        }
    }
}
