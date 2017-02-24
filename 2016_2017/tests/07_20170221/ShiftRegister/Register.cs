using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftRegister
{
    public class Register<IComparable> // Alle Datentypen, die IComparable implementieren, sind als Datentyp erlaubt
    {
        // EventHandler for drop events
        public event EventHandler<IComparable> RaiseDropEventHandler;
        
        // This method is called when an item has to be kicked out due to
        // the number of elements exceeding the capacity of the register.
        protected virtual void OnRaiseDropEvent(IComparable droppedValue)
        {
            EventHandler<IComparable> handler = RaiseDropEventHandler;

            // Event will be null if there are no subscribers
            if (handler != null)
            {
                handler(this, droppedValue);
            }
        }


        public int Count { get; set; }
        public Node<IComparable> Head { get; set; }
        public Node<IComparable> FirstAdded { get; set; }
        private int capacity;

        public Register(int capacity)
        {
            this.capacity = capacity;
        }

        // Add an element to the register and make it the head element.
        // If the count of elements exceeds the capacity, we throw the first
        // element out.
        public void Add(IComparable value)
        {
            Node<IComparable> n = new Node<IComparable>(value);
            if (Head == null)
            {
                Head = n;
                FirstAdded = n;
                Count++;
                return;
            }
            n.Forward = Head;
            Head = n;
            Count++;
            if (Count > capacity)
            {
                // Kick the last element if capacity exceeded
                kickLastElement();
            }
        }

        // Throws out the last element of the register.
        private void kickLastElement()
        {
            // First, raise an event that notifies subscribers that an
            // item has been dropped.
            OnRaiseDropEvent(FirstAdded.Value);

            // Loop over nodes until we reach the element before the first
            // one that was added.
            Node<IComparable> currentNode = Head;
            while (currentNode.Forward != FirstAdded)
            {
                currentNode = currentNode.Forward;
            }
            // Make the element pointing to the first element point to nothing,
            // so the element is not referenced anymore (and can be GC'd).
            currentNode.Forward = null;

            // The new 'first added' element is now the one that was previously pointing
            // to the first element.
            FirstAdded = currentNode;

            // We decrease the count again since we increased it when we added
            // a new element.
            Count--;
        }

        public IComparable First()
        {
            return FirstAdded.Value;
        }

        public IComparable Last()
        {
            return Head.Value;
        }

        public override string ToString()
        {
            if (Head == null)
            {
                return "\n\nRegister is empty";
            }
            StringBuilder sb = new StringBuilder();
            Node<IComparable> currentNode = Head;
            while(currentNode != null)
            {
                sb.AppendLine($"Value: {currentNode.Value}");
                currentNode = currentNode.Forward;
            }
            return sb.ToString();
        }

        public void Clear()
        {
            Head = null;
            FirstAdded = null;
        }
    }
}
