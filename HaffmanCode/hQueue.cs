using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class hQueue : List<queueNode>
    {
        // Methods
        public void AddNode(treeNode el, int pr)
        {
            queueNode item = new queueNode(el, pr);
            if (base.Count == 0)
            {
                base.Add(item);
            }
            else
            {
                for (int i = 0; i < base.Count; i++)
                {
                    if (base[i].priority > pr)
                    {
                        item.next = base[i];
                        if (i > 0)
                        {
                            base[i - 1].next = item;
                        }
                        base.Insert(i, item);
                        return;
                    }
                    if (base[i].next == null)
                    {
                        base[i].next = item;
                        base.Add(item);
                        return;
                    }
                }
            }
        }
    }
}
