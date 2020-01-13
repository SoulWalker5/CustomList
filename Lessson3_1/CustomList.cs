using System;
using System.Collections;

namespace Lessson3_1
{
    public class CustomList : IEnumerable, ICustomList
    {
        public Node Head { get; set; } //link on first element
        public Node Tail { get; set; } //link on Last element
        public Notebook this[int index] => throw new NotImplementedException();
        public void Add(Notebook value)
        {
            //Node node = new Node(value, null);
            if (Head == null)
            {
                Head = new Node (value, null);
                Tail = new Node (value, null);
                //Head.Element.Name = value.Name;
                //Head.Element = value;
                //Tail.Element = value;
            }
            if (Head.Element != null && Head.NextElement == null)
            {
                Head.NextElement = new Node(value, null);
                Tail.Element = value;
            }
            else
            {

            }
        }

        public void Delete(Notebook value)
        {

            throw new NotImplementedException(); // set previous index to Node
        }

        public IEnumerator GetEnumerator()
        {
            return new CustomListIEnumerator();
        }
    }
}
