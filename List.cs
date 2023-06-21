using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class List
    {
        public Node head;

        public void Add(int Data)
        {
            Node node = new Node(Data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;

            }
            Console.WriteLine($"{node.Data} inserted into linked list ");

        }

        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linkedlist is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }


        }

        //public Node Insertion(int position, int Data)
        //{
        //    if (position < 1)
        //        Console.WriteLine("Invalid position");
        //    if (position == 1)
        //    {
        //        var newNode = new Node(Data);
        //        newNode.Next = this.head;
        //        head = newNode;
        //    }
        //    else
        //    {
        //        while (position-- != 0)
        //        {
        //            if (position == 1)
        //            {
        //                Node node = new Node(Data);
        //                node.Next = this.head.Next;
        //                head.Next = node;
        //                break;
        //            }
        //            head = head.Next;
        //        }
        //        if (position != 1)
        //            Console.WriteLine("Position out of range");
        //    }
        //    return head;
        //}


        //Delete first node
        //public Node DeleteFirst()
        //{
        //    if (this.head == null)
        //    {
        //        return null;
        //    }
        //    this.head = this.head.Next;
        //    return this.head;
        //}

        public Node DeleteLast()
        {
            if (this.head == null)
            {
                return null;
            }

            if (head.Next == null)
            {
                return null;
            }
            Node newNode = head;
            while (newNode.Next.Next != null)
            {
                newNode = newNode.Next;
            }

            newNode.Next = null;
            return head;
        }
    }
}
