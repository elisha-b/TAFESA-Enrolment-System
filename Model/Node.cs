using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_Enrolment_System.Model
{
    class Node<T>
    {
        public Node<T> LeftNode { get; set; }

        public Node<T> RightNode { get; set; }

        public T Data { get; set; }
    }
}
