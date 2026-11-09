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
        private int Z = 46;
        private int txtBox1 = 43;
        private int na = 46;
        private int txtBox2 = 43;
        public char rotor1(char c)
        {
            char[] nastaveni = { 'E','K','M','F','L','G','D','Q','V','Z','N','T','O','W','Y','H','X','U','S','P','A','I','B','R','C','J' };
            int znakIndex = comboBox1.SelectedIndex;
            c = (char)comboBox1.Items[nastaveni[znakIndex]];
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
            char[] nastaveni = { 'A', 'J', 'D', 'K', 'S', 'I', 'R', 'U', 'X', 'B','L', 'H', 'W', 'T', 'M', 'C', 'Q', 'G', 'Z', 'N','P', 'Y', 'F', 'V', 'O', 'E' };
            int znakIndex = comboBox1.SelectedIndex;
            c = (char)comboBox1.Items[nastaveni[znakIndex]];
            if (comboBox2.Text == "A")
            {
                int textIndex = comboBox3.SelectedIndex;
                comboBox3.Text = (string)comboBox2.Items[textIndex + 1];
            }
            return c;

        }
        public char rotor3(char c)
        {
            char[] nastaveni = {'B', 'D', 'F', 'H', 'J', 'L', 'C', 'P', 'R', 'T','X', 'V', 'Z', 'N', 'Y', 'E', 'I', 'W', 'G', 'A','K', 'M', 'U', 'S', 'Q', 'O' };
            int znakIndex = comboBox1.SelectedIndex;
            c = (char)comboBox1.Items[nastaveni[znakIndex]];
            return c;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string newText = "";
            bool prvniNaRadku = true;
            char[] znaky = new char[panel3.Controls.Count];
            foreach (Control con in panel3.Controls)
            {
                if (con is TextBox textBox)
                {
                    int i = 0;
                    znaky[i] = Char.Parse(textBox.Text);
                    
                    
                }
            }                                                                                                   
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                for(int j = 0; j < znaky.Length; j++)
                {
                      if( znaky[j] == c )
                    {
                        c = znaky[j + 1];
                    }
                }
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

        private void button2_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = "Z";
            label.Location = new Point(15,Z);
            TextBox textBox = new TextBox();
            textBox.Location = new Point(35,txtBox1);
            Label label2 = new Label();
            label2.Text = "Z";
            label2.Location = new Point(68, na);
            TextBox textBox2 = new TextBox();
            textBox2.Location = new Point(96, txtBox2);
            Z += 26;
            txtBox1 += 26;
            na += 26;
            txtBox2 += 26;
        }
    }
}
