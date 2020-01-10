using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Helpers.BinayTree
{
    public class BinaryTree
    {
        public int val { get; set; }
        public BinaryTree(int val)
        {
            this.val = val;
        }
        public BinaryTree left { get; set; }
        public BinaryTree right { get; set; }

    }
}
