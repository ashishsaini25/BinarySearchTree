using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BinarySearchTree searchTree = new BinarySearchTree();
            searchTree.Add(56);
            searchTree.Add(30);
            searchTree.Add(70);
            searchTree.Display();


        }
    }
}
