using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    public class Node
    {
        private Object data;

        public Node next { get; set; }
        public Node (Object data)
        {
            this.data = data;
        }
    }
}
