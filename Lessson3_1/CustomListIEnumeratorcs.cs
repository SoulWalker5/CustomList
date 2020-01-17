using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson3_1
{
    public class CustomListIEnumerator : IEnumerator
    {
        private Node Head;
        private Node CurrentNode;

        public CustomListIEnumerator(Node node)
        {
            Head = node;
            CurrentNode = null;
        }
        public object Current => Head.Element;

        public bool MoveNext()
        {
            if (CurrentNode == null)
            {
                CurrentNode = Head;
                return true;
                
            }
            else if (Head.Element != null && Head.NextElement != null)
            {
                Head = Head.NextElement;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            Head = null;
        }
    }
}
