using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class tableNode
    {
        // Fields
        public string code;
        public char symbol;

        // Methods
        public tableNode(char sy, string co)
        {
            this.symbol = sy;
            this.code = co;
        }
    }
}
