using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        public int  Data { get; set; }
        public Node left;
        public Node right;
        public Node(int data)
        {
            this.Data = data;
            left=null;
            right=null;
        }

    }
}
