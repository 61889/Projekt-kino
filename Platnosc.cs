using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinoRejestracja
{
    public partial class Platnosc : Form
    {
        List<string> myList = new List<string>();
        string timeMovieName;
        int numberOfSeats;
        public Platnosc(string a, string b, int c)
        {
            numberOfSeats = c;
            myList = a.Split(';').ToList();
            timeMovieName = b;
            InitializeComponent();
        }

        void blik(string number)
        {
            textBox2.Text += number;
            if (textBox2.Text.Length >= 6)
            {
                foreach (var button in this.Controls.OfType<Button>())
                {
                    button.Enabled = false;
                }
                button11.Enabled = true;
            }
        }

        private void Platnosc_Load(object sender, EventArgs e)
        {

        }
        
        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length >= 6)
            {
                using (var sw = new StreamWriter("paragon.txt", append: true))
                {
                    sw.WriteLine(timeMovieName);
                    foreach (var item in myList)
                    {
                        sw.WriteLine(item); 
                    }
                    sw.WriteLine("koszt całkowity wszystkich miejsc: "+(numberOfSeats * 12).ToString()+" pln");
                    sw.WriteLine("---------------------------------------------------------------------------");
                }
            }
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            blik(button10.Text);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            blik(button7.Text);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            blik(button8.Text);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            blik(button9.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            blik(button4.Text);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            blik(button5.Text);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            blik(button6.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            blik(button3.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            blik(button2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            blik(button1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
