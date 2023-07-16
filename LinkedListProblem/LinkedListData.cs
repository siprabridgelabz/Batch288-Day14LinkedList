using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListProblem
{
    public class LinkedListData
    {
        public Node head;
        public void InsertData(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted in linked list", data);
        }

        public void InsertAtPerticularPosition(int position, int data)
        {
            Node n = new Node(data);
            if (this.head == null)
                this.head = n;
            if (position == 0)
            {
                n.next = head;
                head = n;
                return;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            n.next = prev.next;
            prev.next = n;
        }
        public void RemoveFirstElement()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            else
            {
                Node temp = head;
                head = temp.next;
                Console.WriteLine("First element is removed successfully ");
            }
        }



        public void RemoveLastElement()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            if (head.next == null)
            {
                Console.WriteLine("The next element of head is null");
            }
            else
            {
                Node temp = head;
                while (temp.next.next != null)
                {
                    temp = temp.next;//making previous element is first element
                }
                temp.next = null;
            }
            Console.WriteLine("Last element is deleted successfully");
        }
        public void Search_Element(int value)
        {
            Node node = head;
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            int count = 0;
            while (node != null)
            {
                if (node.data == value)
                {
                    Console.WriteLine();
                    //return count;
                }
                node = node.next;
                count++;
            }
            //return count;
        }

        public int SearchElement(int value)
        {
            Node node = head;
            if (node == null)
            {
                return -1;
            }
            int count = 0;
            while (node != null)
            {
                if (node.data == value)
                {
                    Console.WriteLine();
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }

        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
