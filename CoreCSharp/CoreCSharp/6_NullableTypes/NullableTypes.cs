using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCSharp._6_NullableTypes
{
    public class NullableTypes
    {
        public void NullableValueTypeDemo()
        {
            bool isNullable = false;    //Non-nullable value type of bool, can hold only 2 values (true, false), assigning a null throws a compile error

            bool? isNullable2 = null;    //Nullable value type, can hold 3 values (true, false, null)
            
            Nullable<bool> isNullable3 = null;  //this is equivalent to writing bool?
        }

        public void NullableReferenceTypeWithoutNullableContext()
        {
            //This is the default behavior for projects prior C#10 and .NET6

            string referenceType = null;    //null values are allowed as reference types are initialized with null value, before a reference instance is created

            Console.WriteLine(referenceType.ToUpper()); //this throws runtime error without any compile warning

            //can not declare nullable reference string like string?
        }

        public void NullableReferenceTypeWithNullableContext()
        {
            //Since C#8 - can be enabled on particular file, code section or whole project
            //Since C#10 and .NET6 - nullable reference type are enabled by default

            //Non-nullable reference types -> must be assigned non-null value at initialization and can not be later changed to null
            //Nullable referrence types -> must be assigned null or instance of object before beign used

            //Enabling nullable reference type conext:

#nullable enable

            string nonNullableString = null;    //here is a warning, that non-nullable string contains null, therefore runtime exception can happen
            string? nullableString = null;      //no warning for nullable string having a null value

            Console.WriteLine(nonNullableString.ToUpper()); //warning of possible runtime error
            Console.WriteLine(nullableString.ToUpper());

#nullable disable

        }
    }
}
