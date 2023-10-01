using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CoreCSharp._7_Tuples
{
    public static class Tuples
    {
        public static void TuplesDemo()
        {
            //explicit declaration
            (string, int, bool) myFirstTuple = ("hello", 23, true);

            //implicit declaration
            var mySecondTuple = (123, "this tuple has different values", false, true);

            //named properties in tuple are available since C#7
            (string name, int age, bool male) personTuple = ("Jane Lilly", 28, false);
        }

        //Using tuple to return multiple values from a method
        public static (string a, string b, int c) TupleAsReturnParameter()
        {
            return ("string1", "string2", 23);
        }

        //switch expression with tuples and pattern matching
        public static string RockPaperScissors(string firstTip, string secondTip)
        {
            return (firstTip, secondTip) switch
            {
                ("rock", "paper") => "Paper wins",
                ("rock", "scissors") => "Rock wins"
                //and so on..
            };
        }
    }
}
