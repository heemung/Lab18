using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class HowMany
    {

        public int Data
        {
            set; get;
        }
        public static int[] getArrayInt;
        public int[] GetArrayInt
        {
            get
            {
                return getArrayInt;
            }
            set
            {
                getArrayInt = value;
            }
        }
        //public string[] GetArrayString { set; get; }      //other methods counting types of data
        //public LinkedLists GetLinkedList { get; set; }    //other methods counting types of data

        public static void GetSameItems()
        {
            int tempCount = 0;
            int newArraySize = 0;
            int tempX;
            int lengthofArray = getArrayInt.Length;
            int[] tempArray = new int[lengthofArray];
            Array.Copy(getArrayInt, tempArray, getArrayInt.Length);
            Array.Sort(tempArray);

            while (tempArray.Length != 0)
            {
                foreach (var i in tempArray)
                {

                    foreach (var j in tempArray)
                    {
                        if (i == j)
                        {
                            tempCount++;
                        }

                    }

                    Console.WriteLine(i + " is in array " + tempCount + " times");
                    newArraySize = lengthofArray - tempCount;
                    int[] tempArrayTheSecond = new int[newArraySize];

                    tempX = 0;

                    foreach (var k in tempArray)
                    {
                        if (i != k)
                        {
                            tempArrayTheSecond[tempX] = k;
                            tempX++;
                        }

                    }

                    lengthofArray = tempArrayTheSecond.Length;
                    tempArray = new int[lengthofArray];
                    Array.Copy(tempArrayTheSecond, tempArray, lengthofArray);
                    tempCount = 0;
                    break;
                }
            }
        }
    }
}
