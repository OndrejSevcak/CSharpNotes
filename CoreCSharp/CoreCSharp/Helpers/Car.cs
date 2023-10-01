using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCSharp.Helpers
{
    public class Car
    {
        public string Make { get; set; }
        public int ModelYear { get; set; }

        public Car(string make, int modelYear)
        {
            Make = make;
            ModelYear = modelYear;
        }

        public override string ToString()
        {
            return $"{Make} of year {ModelYear}";
        }
    }
}
