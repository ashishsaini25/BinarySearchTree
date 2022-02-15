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
            searchTree.Add(22);
            searchTree.Add(40);
            searchTree.Add(60);
            searchTree.Add(95);
            searchTree.Add(22);
            searchTree.Add(11);
            searchTree.Add(3);
            searchTree.Add(16);
            searchTree.Add(65);
            searchTree.Add(63);
            searchTree.Add(67);
            Console.WriteLine("The size of the binary search Tree :"+searchTree.count);
            searchTree.Display();


        }
    }
}
