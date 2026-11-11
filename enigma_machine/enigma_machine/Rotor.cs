using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enigma_machine
{
    internal class Rotor
    {
        public char rotor1(char c,ComboBox comboBox1, ComboBox comboBox2, ComboBox comboBox3)
        {
            char[] nastaveni = { 'E', 'K', 'M', 'F', 'L', 'G', 'D', 'Q', 'V', 'Z', 'N', 'T', 'O', 'W', 'Y', 'H', 'X', 'U', 'S', 'P', 'A', 'I', 'B', 'R', 'C', 'J' };
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
        public char rotor2(char c,ComboBox comboBox2, ComboBox comboBox3)
        {
            char[] nastaveni = { 'A', 'J', 'D', 'K', 'S', 'I', 'R', 'U', 'X', 'B', 'L', 'H', 'W', 'T', 'M', 'C', 'Q', 'G', 'Z', 'N', 'P', 'Y', 'F', 'V', 'O', 'E' };
            int znakIndex = comboBox2.SelectedIndex;
            c = (char)comboBox2.Items[nastaveni[znakIndex]];
            if (comboBox2.Text == "A")
            {
                int textIndex = comboBox3.SelectedIndex;
                comboBox3.Text = (string)comboBox2.Items[textIndex + 1];
            }
            return c;

        }
        public char rotor3(char c, ComboBox comboBox3)
        {
            char[] nastaveni = { 'B', 'D', 'F', 'H', 'J', 'L', 'C', 'P', 'R', 'T', 'X', 'V', 'Z', 'N', 'Y', 'E', 'I', 'W', 'G', 'A', 'K', 'M', 'U', 'S', 'Q', 'O' };
            int znakIndex = comboBox3.SelectedIndex;
            c = (char)comboBox3.Items[nastaveni[znakIndex]];
            return c;
        }
    }
}
