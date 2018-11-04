using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class HowMany
    {
        private static int[] getArrayInt;
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
            int tempCount = 0;                    //setting temp vars
            int newArraySize = 0;                //setting temp vars
            int tempX;                          //setting temp vars

            int lengthofArray = getArrayInt.Length;

            int[] tempArray = new int[lengthofArray]; // new array temp
            Array.Copy(getArrayInt, tempArray, getArrayInt.Length); //copyes arrray 
            Array.Sort(tempArray); // sorts array

            while (tempArray.Length != 0)            //keeps going until the reinitalized temp array is 0 in length.
            {
                foreach (var i in tempArray)        // goes through all of i
                {

                    foreach (var j in tempArray)    //compares i to j if they match count
                    {
                        if (i == j)
                        {
                            tempCount++;
                        }

                    }

                    Console.WriteLine(i + " is in array " + tempCount + " times"); //prints out of many matches of i there is
                    newArraySize = lengthofArray - tempCount;                      //setting new array size
                    int[] tempArrayTheSecond = new int[newArraySize];              //makes another temp array with new size

                    tempX = 0;                                      //sets new count at 0
                    foreach (var k in tempArray)
                    {
                        if (i != k)                                 //i not equal to k then put value in new array
                        {
                            tempArrayTheSecond[tempX] = k;
                            tempX++;
                        }

                    }

                    lengthofArray = tempArrayTheSecond.Length;      //sets length of array to temp array number 2
                    tempArray = new int[lengthofArray];             //The temp array reinitalizes at a new length equal to the 2nd temp array
                    Array.Copy(tempArrayTheSecond, tempArray, lengthofArray); //copies temp array 2 to the first temp array
                    tempCount = 0;                                  //resets temp count
                    break;                                          //breaks because it would not go back to the first for each loop
                }
            }
        }
    }
}
