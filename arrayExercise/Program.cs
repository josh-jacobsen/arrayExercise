using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayExercise
{
    class MyArray
    {
        static void Main(string[] args)
        {
            string[] myArray = new string [5];

            myArray[0] = "Billy";
            myArray[1] = "Jean";
            myArray[2] = "Randal";

            for (int i = 0; i < myArray.Length; i++)
            {
                // Console.WriteLine(i);
                Console.Write(myArray[i]);
                Console.Write(" ");
            }

            AddEntry(myArray, "Hannah");

            foreach (var entry in myArray)
            {
                Console.Write(entry);
                Console.Write(" ");
            }

            RemoveEntry(myArray, "Jane");

            foreach (var entry in myArray)
            {
                Console.Write(entry);
                Console.Write(" ");
            }


        }
        private static string[] AddEntry(string[] array, string EntryToAdd) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == null)
                {
                    array[i] = EntryToAdd;
                    break;
                }
            }
            return array;
        }
        
        private static string[] RemoveEntry(string[] array, string EntryToRemove)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == EntryToRemove)
                {
                    array[i] = null;
                    //break;
                } else
                {
                    Console.WriteLine("Entry not found");
                    break;
                }
            }
            return array;
        } 
    }
}
