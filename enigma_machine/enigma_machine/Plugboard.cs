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
        List<string> dvojce = new List<string>();
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
    }
}
