using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class treeNode
    {
        // Fields
        public treeNode left;
        public treeNode right;
        public char symbol;

        // Methods
        public treeNode(treeNode le, treeNode ri, char sy)
        {
            this.left = le;
            this.right = ri;
            this.symbol = sy;
        }
    }
}
