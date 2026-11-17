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
        private char pismeno = '_';
        private void button1_Click(object sender, EventArgs e)
        {
            if(pismeno == '_')
            {
                EnigmaEngine enigma = new EnigmaEngine(pismeno);
                pismeno = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
                string s = textBox1.Text;
                string s2 = s + pismeno;
                textBox1.Text = s2;
                pismeno = '_';
            }
            else MessageBox.Show("zadej pismeno na klavesnici");

        }

        private void button2_Click(object sender, EventArgs e)
        {
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
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1,comboBox2,comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button4.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button5.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button6.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button7.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button8.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button9.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button10.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button11.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button12.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button14.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button15.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button16.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button17.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button18.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button19.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button20.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button21.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button22.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button23.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button24.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button25.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button26.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button27.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            char c = char.Parse(button28.Text);
            pismeno = c;
            //EnigmaEngine enigma = new EnigmaEngine(c);
            //c = enigma.SifrovaniDesifrovani(comboBox1, comboBox2, comboBox3);
            //string s = textBox1.Text;
            //string s2 = s + c;
            //textBox1.Text = s2;
        }
    }
}
