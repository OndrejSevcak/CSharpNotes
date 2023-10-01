using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCSharp._1_TypeSystem
{
    public static class _ReferenceTypes
    {
        //C# TYPE SYSTEM - REFERENCE TYPES

        // => contain only the references(address) to their data(object)
        // => two variables can reference the same object, operation on one variable can affect another variable
        // => are stored on the HEAP MEMORY => are garbage collected

        public static void BuildInReferenceTypes()
        {
            object objectReference = "all types in C# unified type system inherits from System.Object";

            dynamic dynamicReference = "this can be of any type, behaves like object in most cases";

            string stringReference = "string is also a reference type, but has overloaded the == operator";
        }

        //User-defined reference types
        public class MyCustomObjectClass { }                        //class type
        public interface IMyCustomObjecInterface { }                //interface type

        public delegate int DelegateReferenceType(int x, int y);    //delegate type
        public record MyRecord { }                                  //record types (immutable by default, behave like value type when comparing equality)
    }
}
