using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_094
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        //Constructor for the node class
        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }
    /* A node class consist os tree things, the information, reference to the right child, and reference to the left child */

    class BinaryTree
    {
        public Node ROOT;
        public BinaryTree()
        {
            ROOT = null; /*Initializing ROOTt to null*/
            
        }
        public void insert(string element) /*Insert a node in the binary search tree*/
        {
            Node tmp, parent = null, currentNode = null;
            search(element, ref parent, ref currentNode);
            if (currentNode != null) /*Check if the node to be inserted already inserted or no*/
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else /*If the spesified node is not present*/
            {
                tmp = new Node(element, null, null); /* creates a Node*/
                if (parent == null) /* If the trees is empty*/
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    parent.leftchild = tmp;
                }
                else
                {
                    parent.rightchild = tmp;
                }
            }
        }
        public void search(string element, ref Node parent, ref Node currentnode)
        {
            /*This function searches the currentNode of the specified Node as well as the current Node of its parent*/
            currentnode = ROOT;
            parent = null;
            while ((currentnode != null) && (currentnode.info != element))
            {
                parent = currentnode;
                if (string.Compare(element, currentnode.info) < 0)
                    currentnode = currentnode.leftchild;
                else
                    currentnode = currentnode.rightchild;
            }
        }
        public void inorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                inorder(ptr.leftchild);
                Console.Write(ptr.info + " ");
                inorder(ptr.rightchild);
            }
        }
        public void preorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                Console.Write(ptr.info + " ");
                preorder(ptr.leftchild);
                preorder(ptr.rightchild);
            }
        }
        public void postorder (Node ptr) /*Perfoms the postorder traversal of the tree*/
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                postorder(ptr.leftchild);
                postorder(ptr.rightchild);
                Console.Write(ptr.info + " ");
            }
        }
        static void Main(string[] args)
        {
            BinaryTree x = new BinaryTree();
            while (true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Implement insert operation");
                Console.WriteLine("2. Perfom inorder traversal");
                Console.WriteLine("3. Perfom preorder traversal");
                Console.WriteLine("4. Perfom postorder traversal");
                Console.WriteLine("5. Exit");
                Console.Write("\nEnter your choice (1-5) : ");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case '1':
                        {
                            Console.Write("Enter a word: ");
                            String word = Console.ReadLine();
                            x.insert(word);
                        }
                        break;
                }
            }
        }

    }
    
       
    
}
