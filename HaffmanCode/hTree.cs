using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class hTree : List<treeNode>
    {
        // Methods
        public hTree(string txt)
        {
            int[] numArray = new int[0x10000];
            for (int i = 0; i < txt.Length; i++)
            {
                numArray[txt[i]]++;
            }
            hQueue queue = new hQueue();
            for (int j = 0; j < 0x10000; j++)
            {
                if (numArray[j] > 0)
                {
                    treeNode el = new treeNode(null, null, Convert.ToChar(j));
                    queue.AddNode(el, numArray[j]);
                }
            }
            while (queue.Count > 1)
            {
                int pr = queue[0].priority + queue[1].priority;
                treeNode node2 = new treeNode(queue[0].val, queue[1].val, Convert.ToChar(0));
                queue.AddNode(node2, pr);
                queue.RemoveAt(1);
                queue.RemoveAt(0);
            }
            base.Add(queue[0].val);
        }

        public string Decode(string stringToDecode)
        {
            string str = "";
            treeNode left = base[0];
            for (int i = 0; i < stringToDecode.Length; i++)
            {
                if (left.symbol != '\0')
                {
                    str = str + left.symbol;
                    left = base[0];
                }
                if (stringToDecode[i] == '0')
                {
                    left = left.left;
                }
                if (stringToDecode[i] == '1')
                {
                    left = left.right;
                }
                if ((stringToDecode[i] != '0') && (stringToDecode[i] != '1'))
                {
                    str = "Не корректная строка кода подлежащая декодированию (допустимы только 1 и 0)";
                }
            }
            if (left.symbol != '\0')
            {
                str = str + left.symbol;
            }
            return str;
        }
    }

}
