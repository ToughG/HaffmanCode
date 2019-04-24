using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class hTable : List<tableNode>
    {
        // Methods
        public hTable(hTree tr)
        {
            this.traverseTree(tr[0], "");
        }

        public string Encode(string stringToEncode)
        {
            string str = "";
            for (int i = 0; i < stringToEncode.Length; i++)
            {
                foreach (tableNode node in this)
                {
                    if (node.symbol == stringToEncode[i])
                    {
                        str = str + node.code;
                        break;
                    }
                }
            }
            return str;
        }

        private void traverseTree(treeNode tn, string cod)
        {
            if (tn.symbol != '\0')
            {
                tableNode item = new tableNode(tn.symbol, cod);
                base.Add(item);
            }
            if (tn.left != null)
            {
                this.traverseTree(tn.left, cod.Insert(cod.Length, "0"));
            }
            if (tn.right != null)
            {
                this.traverseTree(tn.right, cod.Insert(cod.Length, "1"));
            }
        }
    }
}
