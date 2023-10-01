using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCSharp.Arrays
{
    public static class Arrays
    {
        //Array is a data-structure = set of data items, accessed using a numerical index
        //An array can be single-dimensional, multidimensional or jagged.

        public static void TheBaseClass()
        {
            //System.Array

            int[] intArray = { 12, 18, 22, 45 };
            int[] newArray = new int[10];

            //Members of System.Array class
            intArray.CopyTo(newArray,0);
            int length = intArray.Length;
            intArray.Reverse();            
        }

        public static void ArrayInitializationSyntax()
        {
            //using the new keyword
            string[] stringArray = new string[] { "Harry", "Larry", "John" };

            //without new keyword
            int[] intArray = { 12, 15, 70, 987547 };

            //new keyword + size
            bool[] boolArray = new bool[2] { true, false };

            //mixed types
            object[] objectArray = { "hello", 'h', null, 45, 4.5, 4.5m, DateTime.Now }; //string, char, object?, int32, double, decimal, datetime

            foreach (var obj in objectArray)
            {
                if (obj is not null)
                {
                    Console.WriteLine($"Item {obj} is of type {obj.GetType()}");
                }
            }
        }

        public static void ImplicitArrayDeclaration()
        {
            //a is int
            var a = new[] { 10, 8, 7, 6, 13 };

            //b is double
            var b = new[] { 10, 8, 7.5, 6.2, 13 };

            //c is string
            var c = new[] { "hello", null, "something else" };

            //mixed object array can not be declared implicitly
            //var d = new[] { "hello", 23, 7.6m, 'a' };
        }

        public static void MultidimensionalArray()
        {
            //Rectangular array = array of multiple dimensions

            int[,] twoDimensionalArray = new int[4, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
                { 10, 11, 12 },
            };

            int width = twoDimensionalArray.GetLength(0);
            int height = twoDimensionalArray.GetLength(1);

            List<(int x, int y, int val)> valueList = ToEumerable(twoDimensionalArray).ToList();

            foreach (var item in valueList)
            {
                Console.WriteLine($"the value of coordinates x: {item.x}, y: {item.y} is {item.val}");
            }

            //local function
            static IEnumerable<(int x, int y, int val)> ToEumerable(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int y = 0; y < array.GetLength(1); y++)
                    {
                        yield return (i, y, array[i, y]);
                    }
                }
            }
        }

        public static void JaggedArray()
        {
            //Jagged array = contains a number of inner arrays
            int[][] jaggedArray = new int[5][];

            //create the inner arrays
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new int[i + 1];
            }

            //print each row
            for (int i = 0; i < 5; i++)
            {
                for (int y = 0; y < jaggedArray[i].Length; y++)
                {
                    Console.Write(jaggedArray[i][y] + " - ");
                }
                Console.WriteLine();
            }

            //Result:
            //0 -
            //0 - 0 -
            //0 - 0 - 0 -
            //0 - 0 - 0 - 0 -
            //0 - 0 - 0 - 0 - 0 -
        }

    }
}
