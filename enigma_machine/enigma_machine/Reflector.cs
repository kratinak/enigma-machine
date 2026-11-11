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
        public char ReflectorObvodu(char c,ComboBox comboBox1, ComboBox comboBox2, ComboBox comboBox3)
        {
            rotor.rotor3(c, comboBox3);
            rotor.rotor2(c, comboBox2, comboBox3);
            rotor.rotor1(c,comboBox1, comboBox2, comboBox3);
            return c;
        }

    }
}
