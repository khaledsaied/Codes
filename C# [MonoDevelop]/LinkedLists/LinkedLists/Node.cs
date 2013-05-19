using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class Node
    {
        public uint Value { get; set; }
        public Node Next { get; set; }

        public Node(uint _value = 0, Node _next = null)
        {
            Value = _value;
            Next = _next;
        }
    }
}
