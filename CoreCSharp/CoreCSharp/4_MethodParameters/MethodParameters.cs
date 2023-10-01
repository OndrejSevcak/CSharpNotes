using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCSharp.MethodParameters
{
    public static class MethodParameters
    {
        //The default way a parameter is sent to a function is by VALUE = copy of the data is created and passed to the function
        //What exactly is copied depends on whether the parameter is a VALUE type or REFERENCE type

        //Parameter modifiers:
        // none => if there is no parameter modifier specified, parameter is passed to the function by VALUE = copy of the data is created
        // out =>  data passed by REFERENCE and must be assigned by the method being called
        // ref =>  data passed by REFERENCE = may be modified by the called method
        // in  => indicated that ref parameter is read-only
        // params => allows you to send multiple arguments in a single argument variable

        public static void ValueAndReferenceParameters()
        {
            var d = new DemoClass();    //value of d is a reference address(0x2ABSJHDZS) to the actual object created on HEAP

            void TestMethod(DemoClass valueParameter)
            {
                valueParameter.Name = "John";  //valueParameter is a parameter passed by VALUE
                valueParameter = null;
            }

            void TestMethod2(ref DemoClass referenceParameter)
            {
                referenceParameter = null;
            }

            TestMethod(d);  
            //when we call the TestMethod method, the reference value of d is copied to a new storage location on STACK
            //now d and valueParameter point to the same object on HEAP
            //if we use the valueParameter to mutate the existing instance, also the instance pointed by d will be mutated
            //if we assign the valueParameter to null, new storage location will be created for valueParameter
            //with d still pointint to the original object

            TestMethod2(ref d);
            //when we call the TestMethod2 method, SAME storage location is used for referenceParameter as we already have for d
            //reference value is NOT copied
            //assigning referenceParameter to null inside the method caused the original d reference being overwritten by new adress (0x000000)


            if (d is null)
            {
                throw new ArgumentNullException(nameof(d));
            }
            Console.WriteLine("The Name currently stored in the original instance d is {0}", d.Name);   //John

        }
    }

    public class DemoClass 
    {
        public string Name { get; set; } = "Larry";
    }
}
