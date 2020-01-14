using System;
using System.Collections;

namespace Lessson3_1
{
    public class CustomList : IEnumerable, ICustomList
    {
        public int Counter;
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
                Counter = 0;
            }
            else
            {
                Tail.NextElement = node;
                Tail = node;
                Counter++;
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
                    //Counter--;
                }
                previous = current;
                current = current.NextElement;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new CustomListIEnumerator();
        }

        //public class CustomListIEnumerator : IEnumerator
        //{
        //    public object Current => throw new NotImplementedException();

        //    public bool MoveNext()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void Reset()
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }
}
