using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;

namespace NodePractice2
{
    class Program
    {
        //Implemented Methods to Manage Linked List
        static void Print(Node<int> p)
        {
            //prints all values in Linked List that starts at p
            Console.Write("[");
            if (p != null)
            {
                Console.Write("{0}", p.GetValue());
                p = p.GetNext();
            }
            while (p != null)
            {
                Console.Write(", {0}", p.GetValue());
                p = p.GetNext();
            }
            Console.Write("]");
        }
        static void Print(Node<Point> p)
        {
            //prints all values in Linked List that starts at p
            Console.Write("[");
            if (p != null)
            {
                Console.Write("{0}", p.GetValue());
                p = p.GetNext();
            }
            while (p != null)
            {
                Console.Write(", {0}", p.GetValue());
                p = p.GetNext();
            }
            Console.Write("]");
        }
        static int Length(Node<int> p)
        {

            // find how many nodes after p
            if (p == null) return 0;
            return Length(p.GetNext()) + 1;
        }
        static Node<int> GetLast(Node<int> p)
        {
            //finds the last node in linked Nodes
            return Prev(p, null);
        }
        public static Node<int> Prev(Node<int> first, Node<int> p)
        {
            while (first.GetNext() == p)
                return first;
            return Prev(first.GetNext(), p);
        }
        static bool Found(Node<int> first, int x)
        {
            //finds if x is in first
            if (first == null) return false;
            if (first.GetValue() == x) return true;
            return Found(first.GetNext(), x);
        }
        static int Count(Node<int> first, int number)
        {
            //counts how many times the in number appears in the Linked Node List
            if (first == null) return 0;
            return Count(first.GetNext(), number) + first.GetValue() == number ? 1 : 0;
        }


        public int Sum(Node<int> first)
        {
            // returns the sum of nodes in linked nodes
            if (first == null) return 0;
            return Sum(first.GetNext()) + first.GetValue();
        }
        //Exercises to Solve

        static void Swap(Node<int> p, Node<int> q)
        {
            throw new NotImplementedException();
        }
        public double GetAverage(Node<int> first)
        {
            // returns the average of all nodes
            throw new NotImplementedException();
        }

        static bool HasAllNumbers (Node<int> l1, Node<int>l2)
        {
            // all numbers in l1, exist in l2
            throw new NotImplementedException();
        }
        static Node<int> LongestSeries (Node<int> p)
        {
            //2-> 3-> 3 -> 1->1->1 ->5
            // finds the longest series of nodes with same value consequetively 
            throw new NotImplementedException();
        }
        static bool IsSorted(Node<int> p)
        {
            // checks and returns whether nodes are sorted or not
            throw new NotImplementedException();
        }
        
        public static void Abc(Node<int> p)
        {
            Node<int> last = Prev(p, null);
            Rec(p, last);
        }
        public static void Rec(Node<int> p, Node<int> q)
        {
            if (p != q)
            {
                while (p != q && p.GetValue() % 2 == 0)
                    p = p.GetNext();
                while (q != p && q.GetValue() % 2 == 1)
                    q = Prev(p, q);
                if (p != q)
                {
                    Swap(p, q);
                    Rec(p, q);
                }
            }
        }
       static Node<int> Misery (Node<int> p, int x)
        {
            if (p == null)
                return p;
            Node<int> temp = Misery(p.GetNext(),x);
            if (p.GetValue() != x)
            {
                p.SetNext(temp);
                return p;
            }
            return temp;
        }
        static Node<int> Misery1 (Node<int> p , int x)
        {
            Node<int> dummy = new Node<int>(-1, p);
            Node<int> prev = dummy;
            while (p!= null)
            {
                if (p.GetValue()==x)
                {
                    prev.SetNext(p.GetNext());
                    p = p.GetNext();
                }
                else
                {
                    prev = p;
                    p = p.GetNext();
                }
            }
            return dummy.GetNext();
        }
        static void LessMisery (Node<int> head)
        {
            while (head != null && head.GetNext() != null)
            {
                head.SetNext(Misery(head.GetNext(), head.GetValue()));
                head = head.GetNext();
            }
        }
        static void Main(string[] args)
        {
            Node<Point> n = GenerateNodesModule.GetPointList(5);
            Print(n);
            //Console.WriteLine("Get a number =>");
            //int x = int.Parse(Console.ReadLine());
            //n = Misery1(n, x);
           
            Print(n);
            Console.ReadKey();

        }
    }
}
