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
        
        private void button1_Click(object sender, EventArgs e)
        {
            //string text = textBox1.Text;
            //string newText = "";
            //bool prvniNaRadku = true;
            //char[] znaky = new char[panel3.Controls.Count];
            //foreach (Control con in panel3.Controls)
            //{
            //    if (con is TextBox textBox)
            //    {
            //        int i = 0;
            //        znaky[i] = Char.Parse(textBox.Text);
                    
                    
            //    }
            //}                                                                                                   
            //for (int i = 0; i < text.Length; i++)
            //{
            //    char c = text[i];
            //    for(int j = 0; j < znaky.Length; j++)
            //    {
            //          if( znaky[j] == c )
            //        {
            //            c = znaky[j + 1];
            //        }
            //    }
            //    c = Rotor.rotor1(c,comboBox1,comboBox2,comboBox3);
            //    c = rotor2(c);
            //    c = rotor3(c);
            //    c = rotor3(c);
            //    c = rotor2(c);
            //    c = rotor1(c);

            //    if (i != 0)
            //    {
            //        newText = text.Substring(i - 1, i) + c + text.Substring(i + 1);
            //    }
            //    else
            //    {
            //        newText = c + text.Substring(i + 1);
            //    }
            //}
            //MessageBox.Show("zašifrovaný text " + newText);
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

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            foreach(Control control in panel1.Controls)
            {
                if(control is CheckBox checkBox)
                {
                    int pocet =  0;
                    bool prvni = true;
                    string prvniClen = "";
                    string druhyClen = "";
                    while (pocet < 2)
                    {
                        if(checkBox.Checked && prvni)
                        {
                            prvniClen = checkBox.Text;
                            prvni = true;
                        }
                        else if(checkBox.Checked && !prvni)
                        {
                            druhyClen = checkBox.Text;
                        }
                        pocet++;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button3.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1,comboBox2,comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button4.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button5.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button6.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button7.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button8.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button9.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button10.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button11.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button12.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button14.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button15.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button16.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button17.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button18.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button19.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button20.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button21.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button22.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button23.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button24.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button25.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button26.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button27.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button28.Text);
            EnigmaEngine enigma = new EnigmaEngine(c);
            c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            string s = textBox1.Text;
            string s2 = s + c;
            textBox1.Text = s2;
        }
    }
}
