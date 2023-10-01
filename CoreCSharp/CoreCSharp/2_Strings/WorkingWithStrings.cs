using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCSharp.Strings
{
    public static class WorkingWithStrings
    {
        //STRING = a sequence of characters. Each character is a Unicode character in the range U+0000 to U+FFFF
        //is a reference type, is immutable, can contain nulls, overloads the == operator

        public static void CharExample()
        {
            //System.Char is a VALUE type that represents a UNICODE UTF-16 character
            //Default value is \0, whis is U+0000

            var chars = new[]
            {
                'j',        // - character literal
                '\u006A',   // - unicode four-symbol hex representation
                '\x006A',   // - hexadecimal escape sequence
                (char)106   // - casting
            };

            Console.WriteLine(String.Join(" - ", chars));  // j - j - j - j
        }

        /// <summary>
        /// Strings are immutable
        /// </summary>
        public static void StringImmutability()
        {
            string s1 = "Hello from C#";
            string s2 = s1.ToUpper();

            Console.WriteLine(s1); //s1 is still the same, because s2 is created as new object in memory
            Console.WriteLine(s2);
        }

        /// <summary>
        /// StringBuilder is used for optimized working with strings being able to modify the string object directly
        /// without creating a new string every time
        /// </summary>
        public static void UsingStringBuilder()
        {
            string s1 = "Hello from C#";
            Console.WriteLine(s1);

            StringBuilder sb = new StringBuilder(s1);
            sb.Append("\n");
            sb.Append("\n");
            sb.Append("This is another line that will be appended to the original string");

            Console.WriteLine(sb.ToString());
        }

        /// <summary>
        /// String overloads the == operator
        /// </summary>
        public static void StringEquality()
        {
            //Equality tests on reference types using == by default compares the reference they are pointing to
            //But the equality operators are redefined for STRINGS to compare their VALUES instead of objects in memory to which they refer

            string s1 = "This is first string";
            string s2 = "This is second string";

            Console.WriteLine($"s1 = {s1}, s2 = {s2}");
            Console.WriteLine($"Are those strings equal using .Equals() ? {s1.Equals(s2)}");    //No, different values and references
            Console.WriteLine($"Are those strings equal using == ? {s1 == s2}");

            s2 = "This is first string";
            Console.WriteLine($"Are those strings equal using .Equals() ? {s1.Equals(s2)}");    //Yes, different references but same values
            Console.WriteLine($"Are those strings equal using == ? {s1 == s2}");
        }

        public static void ObjectEquality()
        {
            Person p1 = new Person("John", "Senna", new DateTime(1984, 05, 12));
            Person p2 = new Person("John", "Senna", new DateTime(1984, 05, 12));

            Console.WriteLine($"Are those two objects with same values equal? {p1.Equals(p2)}");    //Not equal

            p1 = p2;

            Console.WriteLine($"Are now equal? {p1.Equals(p2)}, because they contain the same reference to memory object (HEAP)"); //Equal
        }

        
    }
}
