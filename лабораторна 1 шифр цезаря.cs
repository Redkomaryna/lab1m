using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public char[] bukva = { 'а', 'б', 'в', 'г', 'ґ', 'д', 'е', 'є', 'ж', 'з', 'и', 'і', 'ї',
        'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ю', 'я'};

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";

            string str = textBox1.Text.ToLower();
            int key = Convert.ToInt32(textBox4.Text);
            foreach (char c in str)
            {
                if (c != ' ')
                {
                    for (int i = 0; i < bukva.Length; i++)
                    {
                        if(c== bukva[i])
                        {
                            int j = (i + key) % 33;// 32+3=35 35/33=1 ост=2
                            textBox2.Text += bukva[j];

                        }
                    }
                }
                else 
                {
                    textBox2.Text += ' ';
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";

            string str = textBox2.Text.ToLower();
            int key = Convert.ToInt32(textBox4.Text);
            foreach (char c in str)
            {
                if (c != ' ')
                {
                    for (int i = 0; i < bukva.Length; i++)
                    {
                        if (c == bukva[i])
                        {
                            int j = (i + (33 -key)) % 33;
                            textBox3.Text += bukva[j];

                        }
                    }
                }
                else
                {
                    textBox3.Text += ' ';
                }
            }
        }
    }
}
