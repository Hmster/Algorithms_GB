using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_GB
{
    public interface ILinkedList<T>
    {
        /// <summary>
        /// возвращает количество элементов в списке
        /// </summary>
        /// <returns></returns>
        int GetCount();

        /// <summary>
        /// добавляет новый элемент списка
        /// </summary>
        /// <param name="value"></param>
        void AddNode(T value);

        /// <summary>
        /// добавляет новый элемент списка после определённого элемента
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        void AddNodeAfter(DLNode<T> node, T value);

        /// <summary>
        /// удаляет элемент по порядковому номеру
        /// </summary>
        /// <param name="index"></param>
        void RemoveNode(int index);

        /// <summary>
        /// удаляет указанный элемент
        /// </summary>
        /// <param name="node"></param>
        void RemoveNode(DLNode<T> node);

        /// <summary>
        /// ищет элемент по его значению
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        DLNode<T> FindNode(T searchValue);
    }
}
