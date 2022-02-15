using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
   
    public class BinarySearchTree
    {
        public Node root;
        public int count = 0;
        public BinarySearchTree()
        {
            root = null;
        }

        public void Add(int data)
        {
            count++;
            if(root == null)
            {
                root = new Node(data);
                return;
            }
            Insert(root, new Node(data));
        }
        public void Insert(Node root,Node newnode)
        {
  
            if (root.Data > newnode.Data)
             {
                if(root.left == null)
                {
                    root.left = newnode;
                    return;
                }
                Insert(root.left, newnode);
            }
            else
            {
                if (root.right == null)
                {
                    root.right = newnode;
                    return;
                }
                Insert(root.right, newnode);
            }

        }
        public bool Search(int data)
        {
            return SearchElement(data, root);
        }
        public bool SearchElement(int data,Node root)
        {
            if (root == null) return false;
            if (root.Data == data) return true;
            if (root.Data < data) return SearchElement(data, root.right);
            else 
                return SearchElement(data, root.left);
        }
        private void DisplayTree(Node root)
        {
            if (root == null) return;

            DisplayTree(root.left);
            System.Console.Write(root.Data + " ");
            DisplayTree(root.right);
        }
        public void Display()
        {
            DisplayTree(root);
        }
    }
}
