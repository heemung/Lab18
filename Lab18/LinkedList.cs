using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class LinkedLists
    {
        public Node Head { set; get; }
        public Node Tail { set; get; }
        public int Count { set; get; }

        public void AddHead(int userInput)
        {

        }
        public void Add(int userInput)
        {
            Node newNode = new Node { Next = null, Data = userInput };
            if (Count == 0)
            {
                Head = newNode;
                Tail = newNode;
                Count++;
            }
            else
            {
                newNode.Previous = Tail; //change the previous reference in the new node

                Tail.Next = newNode; //change the tail next reference

                Tail = newNode; //change the tail
                Count++;
            }
        }
        public bool InsertAt(int index, Node o)
        {
            Node temp;
            if (index < 0 || index > Count) // makes sure input is in range, returns false if it doesnt
            {
                Console.WriteLine("out of range");
                return false;
            }
            else
            {
                temp = GetNode(index);

                if (index == 0)//index at the start will have the head point to o and update references
                {
                    Head = o;
                    o.Next = temp;
                    o.Previous = null;
                    temp.Previous = o;

                }
                else if (index == Count)
                {
                    temp = Tail;
                    o.Previous = temp;
                    o.Next = null;
                    temp.Next = o;
                    Tail = o;
                }
                else // normal
                {
                    o.Next = temp; // New object Next ref equals temp Object
                    o.Previous = temp.Previous;// New object Previous ref equals temp Objects previous
                    temp.Previous.Next = o; // temps previous ref object, That object Next equals New object
                    temp.Previous = o; // temp previous ref equals new object 

                }
                Count++; //because of inserting, Add a number to the list Add a number to the count
                return true;
            }
        }
        public bool RemoveAt(int index)
        {
            Node temp;

            //return temp;
            if (index < 0 || index >= Count)
            {
                Console.WriteLine("out of range");
                return false;
            }
            else
            {
                temp = GetNode(index);

                if (index == 0)//index at the start will have the head point to o and update references
                {
                    Head = temp.Next;
                    temp.Next.Previous = null;
                    temp = null;    

                }
                else if (index == Count - 1) //making sure objects stay within range
                {
                    temp = Tail; //starting at tail pointer Object
                    Tail = temp.Previous; // Tail equals Object previous
                    temp.Previous.Next = null; //Objects previous equals null since we delete Object
                    temp = null; // Object equals null , garbage should collect it
                }
                else // normal
                {
                    temp.Next.Previous = temp.Previous; //Objects ref Nexts previous ref equals the Objects previous
                    temp.Previous.Next = temp.Next; // objects ref previouss ref next equals the Objects Next
                    temp = null; // Set object to null, garbage should collect it
                }
                Count--; // count -- because there is one less object
                return true;
            }
        }

        public Node GetNode(int index)
        {
            int start = 0;
            Node temp = Head; //mark the start of search

            while (start != index)
            {
                start += 1;
                temp = temp.Next;
            }
            return temp;
        }

        public Node GetNodePrevious(int index)
        {
            int start = 0;
            Node temp = Tail; //mark the start of search

            while (start != index)
            {
                start += 1;
                temp = temp.Previous;
            }
            return temp;
        }

        public void PrintList()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(GetNode(i).Data);
            }
        }

       public void PrintReverse()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(GetNodePrevious(i).Data);
            }
        }
    }
}
