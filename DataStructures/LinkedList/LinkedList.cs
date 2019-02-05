using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    public class LinkedList
    {
        private Node head;

        public void Add(Node node)
        {
            node.next = this.head;
            this.head = node;
        }
        
    }
}
