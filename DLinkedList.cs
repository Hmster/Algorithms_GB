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

        /// <summary>
        /// Add item after tail
        /// </summary>
        /// <param name="value"></param>
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

        /// <summary>
        /// Add item after given
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        public void AddNodeAfter(DLNode<T> node, T value)
        {
            var newNode = new DLNode<T>(value);
            var nextNode = node.NextNode;
            node.NextNode = newNode;
            newNode.NextNode = nextNode;
            newNode.PrevNode = node;
            nextNode.PrevNode = newNode;
        }

        /// <summary>
        /// Find node by value
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public DLNode<T> FindNode(T searchValue)
        {
            var currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(searchValue))
                    return currentNode;
                currentNode = currentNode.NextNode;
            }
            return null; 
        }

        /// <summary>
        /// Remove node by index
        /// </summary>
        /// <param name="itemIndex"></param>
        public void RemoveNode(int itemIndex)
        {
            int currentIndex = 0;
            var currentNode = head;
            while (currentNode != null)
            {
                if (currentIndex == itemIndex - 1)
                {
                    RemoveNode(currentNode);
                }
                currentNode = currentNode.NextNode;
                currentIndex++;
            }
        }

        /// <summary>
        /// Remove node
        /// </summary>
        /// <param name="node"></param>
        public void RemoveNode(DLNode<T> node)
        {

            var nextNode = node.NextNode;
            var prevNode = node.PrevNode;
            if (node.PrevNode == null)
                head = nextNode;
            else if (node.NextNode == null)
                tail = prevNode;
            else
            {
                prevNode.NextNode = nextNode;
                nextNode.PrevNode = prevNode;
            }
        }

        /// <summary>
        /// Get number of nodes
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int GetCount()
        {
            int currentIndex = 0;
            var currentNode = head;
            while (currentNode != null)
            {
                currentNode = currentNode.NextNode;
                currentIndex++;
            }
            return currentIndex;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
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
    }
}
