using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_GB
{
    internal class DLinkedList<T> : ILinkedList<T>, IEnumerable<T>
    {
        int count;
        DLNode<T> head;
        DLNode<T> tail;

        public void AddNode(T value)
        {
            var newNode = new DLNode<T>(value);

            if (head == null)
                head = newNode;
            else
            {
                tail.NextNode = newNode;
                newNode.PrevNode = tail;
            }
            tail = newNode;
            count++;
        }

        public void AddNodeAfter(DLNode<T> node, T value)
        {
            throw new NotImplementedException();
        }

        public DLNode<T> FindNode(T searchValue)
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.NextNode;
            }
        }

        public void RemoveNode(int index)
        {
            throw new NotImplementedException();
        }

        public void RemoveNode(DLNode<T> node)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
