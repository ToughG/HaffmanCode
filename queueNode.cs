using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class queueNode
    {
        // Fields
        public queueNode next;
        public int priority;
        public treeNode val;

        // Methods
        public queueNode(treeNode el, int pr)
        {
            this.val = el;
            this.priority = pr;
            this.next = null;
        }
    }
}
