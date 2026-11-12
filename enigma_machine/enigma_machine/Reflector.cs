using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enigma_machine
{
    internal class Reflector
    {
        Rotor rotor = new Rotor();
        char[] nastaveni = { 'K', 'E', 'M', 'G', 'L', 'F', 'B', 'Q', 'V', 'Z', 'X', 'W', 'J', 'T', 'H', 'Y', 'N', 'U', 'S', 'P', 'A', 'I', 'D', 'C', 'R', 'O' };
        char[] abeceda = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        public char ReflectorObvodu(char c,ComboBox comboBox1, ComboBox comboBox2, ComboBox comboBox3)
        {
            for (int i = 0; i < abeceda.Length; i++)
            {
                if (abeceda[i] == c)
                {
                    c = nastaveni[i];
                }
            }
            rotor.rotor3(c, comboBox3);
            rotor.rotor2(c, comboBox2, comboBox3);
            rotor.rotor1(c,comboBox1, comboBox2, comboBox3);
            return c;
        }

    }
}
