using System;
using System.Collections;

namespace Lessson3_1
{
    public class CustomList : IEnumerable, ICustomList
    {
        public Node Head { get; set; } //link on first element
        public Node Tail { get; set; } //link on Last element
        public Notebook this[int index]
        {
            get
            {
                Node current = Head;
                int i = 0;

                while (current != null && i != index)
                {
                    current = current.NextElement;
                    i++;
                }
                return current.Element;
            }
        }

        public void Add(Notebook value)
        {
            Node node = new Node(value, null);
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.NextElement = node;
                Tail = node;
            }
        }

        public void Delete(Notebook value)
        {
            Node previous = null;
            Node current = Head;

            while (current != null)
            {
                if (current.Element.Equals(value))
                {
                    if (previous != null)
                    {
                        previous.NextElement = current.NextElement;
                        {
                            if (current.NextElement == null)
                            {
                                Tail = previous;
                            }
                        }
                    }
                    else
                    {
                        Head = Head.NextElement;
                        if (Head == null)
                        {
                            Tail = null;
                        }
                    }
                }
                previous = current;
                current = current.NextElement;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new CustomListIEnumerator(Head);
        }
    }
}
