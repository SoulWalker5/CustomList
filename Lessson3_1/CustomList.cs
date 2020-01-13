using System;
using System.Collections;

namespace Lessson3_1
{
    public class CustomList : IEnumerable, ICustomList
    {
        //public int Counter;
        public Node Head { get; set; } //link on first element
        public Node Tail { get; set; } //link on Last element
        public Notebook this[int index] => throw new NotImplementedException();
        public void Add(Notebook value)
        {
            Node node = new Node(value, null);
            if (Head == null)
            {
                Head = node;
                Tail = node;
                //Counter = 0;
            }
            else
            {
                Tail.NextElement = node;
                Tail = node;
                //Counter++;
            }
        }

        public void Delete(Notebook value)
        {
            return new CustomListIEnumerator(); // set previous index to Node
        }

        public IEnumerator GetEnumerator()
        {
            return new CustomListIEnumerator();
        }
    }
}
