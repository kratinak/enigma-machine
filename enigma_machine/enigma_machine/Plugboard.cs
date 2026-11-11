using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enigma_machine
{
    internal class Plugboard
    {
        private string clen1 = "";
        private string clen2 = "";
        public List<string> dvojce = new List<string>();
        public Plugboard(string clen1, string clen2)
        {
            this.clen1 = clen1;
            this.clen2 = clen2;
        }
        public Plugboard()
        {

        }
        public void Zapsat()
        {
            dvojce.Add(clen1 + clen2);
        }
        public char zmenaPismena(char c)
        {
            bool nalezen = false;
            for (int i = 0; i < dvojce.Count() && !nalezen; i++)
            {
                string s = dvojce[i].ToString();
                if (s[0] == c)
                {
                    c = s[1];
                    nalezen = true;
                }
                else if (s[1] == c)
                {
                    c = s[0];
                    nalezen = true;
                }
            }
            return c;
        }
    }
}
