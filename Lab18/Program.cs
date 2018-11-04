using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        public static LinkedLists myList = new LinkedLists();
        static void Main(string[] args)
        {
            AddLinkListData();
            myList.PrintList();
            Console.WriteLine("Now in reverse\n");
            myList.PrintReverse();
            Node insertList = new Node { Next = null, Previous = null, Data = 100 };
            myList.InsertAt(0, insertList); // change where to insert at here
            Console.WriteLine("After Insert\n");
            myList.PrintList();
            Console.WriteLine("After remove\n");
            myList.RemoveAt(15); // change where to remove here
            myList.PrintList();

            Console.WriteLine("\nNow for count array\n"); // starts the algorim in Howmany
            HowMany myCounting = new HowMany();
            myCounting.GetArrayInt = AddArray();
            HowMany.GetSameItems();
            Console.ReadLine();
        }

        public static void AddLinkListData()
        {
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);
            myList.Add(9);
            myList.Add(10);
            myList.Add(11);
            myList.Add(12);
            myList.Add(13);
            myList.Add(14);
            myList.Add(15);
        }

        public static int[] AddArray() //ARRAY for algorithm
        {
            int[] myArray = new int[]{ 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 10 };

            return myArray;
        }
    }
}
