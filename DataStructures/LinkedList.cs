using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedList
    {
        private Node head;

        public void addNode(Object data)
        {
            Node addNode = new Node();

            addNode.data = data;

            Node current = head;
            current.next = addNode;


        }

        public void printAllNodes()
        {

        }


    }
}
