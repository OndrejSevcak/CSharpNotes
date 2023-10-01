using CoreCSharp._5_Structures;
using CoreCSharp.Helpers;
using CoreCSharp.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCSharp._1_TypeSystem
{
    public static class StackVsHeapConcept
    {
        //HEAP  - reference types are allocated on the HEAP memory
        //STACK - value types are allocaed on the STACK memory

        //System.ValueType - ensures that derived type is allocated on the STACK memory
        //                 - data allocated on STACK can be created and destoryed very fast
        //                 - STACK allocated data have defined lifetime by their defining scope
        //                 - overrides virual method of System.Object
        //                 - data directy contain their values


        //STACK object lifetime
        public static void StackLifeTime()
        {
            Point myPointStruct = new Point(5, 2);  //Point struct value type is created on the stack in the scope of this method

        }//here myPointStruct is deleted from Stack


        //Assigning one value type to another = copy of the data is created
        public static void ValueTypeAssignemtDemo()
        {
            int a = 20;
            int b = a;

            Console.WriteLine(a);   //20
            Console.WriteLine(b);   //20

            a = 35;

            Console.WriteLine(a);   //35
            Console.WriteLine(b);   //20 -> b has not changed because it contains its own copy of the data
        }

        //Assigning one reference type to another = copy of the reference address pointing to the same object is created
        public static void ReferenceTypeAssignmentDemo()
        {
            Car bmw = new Car("BMW", 2020);
            Car bmw2 = bmw;

            Console.WriteLine(bmw.ToString());      //BMW of year 2020
            Console.WriteLine(bmw2.ToString());     //BMW of year 2020

            bmw.ModelYear = 1998;

            Console.WriteLine(bmw.ToString());      //BMW of year 1998
            Console.WriteLine(bmw2.ToString());     //BMW of year 1998   -> bmw2 has changed too, becase it points to the same object as bmw
        }
    }
}
