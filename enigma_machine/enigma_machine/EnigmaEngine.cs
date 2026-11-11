using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enigma_machine
{
    internal class EnigmaEngine
    {
        private char c = ' ';
        Plugboard plug = new Plugboard();
        Rotor rotor = new Rotor();
        Reflector reflector = new Reflector();
        public EnigmaEngine() 
        {

        }
        public EnigmaEngine(char c)
        {
            this.c = c;
        }
        public char SifrovaniDesifrovani(ComboBox comboBox1 , ComboBox comboBox2,ComboBox comboBox3)
        {
            plug.zmenaPismena(c);
            rotor.rotor1(c,comboBox1,comboBox2,comboBox3);
            rotor.rotor2(c, comboBox2, comboBox3);
            rotor.rotor3(c, comboBox3);
            reflector.ReflectorObvodu(c,comboBox1, comboBox2,comboBox3);
            plug.zmenaPismena(c);
            return c;
        }

    }
}
