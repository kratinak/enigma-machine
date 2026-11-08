using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enigma_machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public char rotor1(char c)
        {
            int znakIndex = comboBox1.SelectedIndex;
            c = (char)comboBox1.Items[znakIndex + 3];
            comboBox1.Text = (string)comboBox1.Items[znakIndex + 1];
            if (comboBox1.Text == "A")
            {
                int textIndex = comboBox2.SelectedIndex;
                comboBox2.Text = (string)comboBox2.Items[textIndex + 1];
                if (comboBox2.Text == "A")
                {
                    int textIndex2 = comboBox3.SelectedIndex;
                    comboBox3.Text = (string)comboBox2.Items[textIndex2 + 1];
                }
            }
            return c;
        }
        public char rotor2(char c)
        {
            int znakIndex = comboBox1.SelectedIndex;
            c = (char)comboBox1.Items[znakIndex + 3];
            if (comboBox2.Text == "A")
            {
                int textIndex = comboBox3.SelectedIndex;
                comboBox3.Text = (string)comboBox2.Items[textIndex + 1];
            }
            return c;

        }
        public char rotor3(char c)
        {
            int znakIndex = comboBox1.SelectedIndex;
            c = (char)comboBox1.Items[znakIndex + 3];
            return c;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string newText = "";
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                c = rotor1(c);
                c = rotor2(c);
                c = rotor3(c);
                c = rotor3(c);
                c = rotor2(c);
                c = rotor1(c);
                if (i != 0)
                {
                    newText = text.Substring(i - 1, i) + c + text.Substring(i + 1);
                }
                else
                {
                    newText = c + text.Substring(i + 1);
                }
            }
            MessageBox.Show("zašifrovaný text " + newText);
        }
    }
}
