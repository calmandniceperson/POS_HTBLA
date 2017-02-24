using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftRegister
{
    public class Node<IComparable>
    {
        public IComparable Value { get; set; }
        public Node<IComparable> Forward { get; set; }

        public Node(IComparable value)
        {
            Value = value;
        }
    }
}
