using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_GB
{
    public class DLNode<T>
    {
        public DLNode(T value)
        {
            Value = value;
        }
        /// <summary>
        /// полезная нагрузка
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// ссылка на следующий элемент
        /// </summary>
        public DLNode<T> NextNode { get; set; }

        /// <summary>
        /// ссылка на предыдущий элемент
        /// </summary>
        public DLNode<T> PrevNode { get; set; }

    }
}
