﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DataStructures.BinaryTree
{
    public class Node
    {
        public int value;
        public Node left;
        public Node right;
    }
    public class Tree
    {
        public Node insert(Node root, int v)
        {
            if (root == null)
            {
                root = new Node();
                root.value = v;
            }
            else if (v < root.value)
            {
                root.left = insert(root.left, v);
            }
            else
            {
                root.right = insert(root.right, v);
            }
            return root;
        }
        public void traverse(Node root)
        {
            if (root == null)
            {
                return;
            }
            traverse(root.left);
            traverse(root.right);
        }
    }
}
