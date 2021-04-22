using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;
namespace NodePractice2
{
    class GenerateNodesModule
    {
        public static Node<int> Generate_Nodes(int count)
        {
            Random rnd = new Random();
            Node<int> first = new Node<int>(rnd.Next(30) + 1);
            Node<int> last = first;
            for (int i = 1; i < count; i++)
            {
                last.SetNext(new Node<int>(rnd.Next(30) + 1));
                last = last.GetNext();
            }
            return first;
        }
        public static Node<Point> GetPointList (int size)
        {
            Node<Point> head = new Node<Point>(new Point(-1,-1));
            Node<Point> last = head;
            Random rnd = new Random();
            for (int i=0; i < size; i++)
            {
                last.SetNext(new Node<Point>(new Point (rnd.Next(20), rnd.Next(20))));
                last = last.GetNext();
            }
            return head.GetNext();
        }
    }
}
