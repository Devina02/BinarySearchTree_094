﻿using System;
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
            Search(element, ref parent, ref currentNode);
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

    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
