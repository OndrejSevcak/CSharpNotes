using CoreCSharp.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCSharp._5_Structures
{
    public class Structures
    {
        //STRUCT = user defined VALUE TYPE
        // - can not inherit from other structure or class
        // - can not be a base class
        // - can implement interfaces
        // - are implicitly derived from System.ValueType
    }

    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void IncreaseX(int increment)
        {
            X += increment;
        }
    }

    public struct PointWithFiledInitializers
    {
        public int X { get; set; } = 5;
        public int Y { get; set; } = 10;

        public PointWithFiledInitializers(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    /// <summary>
    /// Immutable - readonly struct, immutable objects must be set up on construction and can not be changed later
    /// </summary>
    public readonly struct PointReadOnly 
    {
        public int X { get; }
        public int Y { get; }

        public PointReadOnly(int x, int y)
        {
            X = x;
            Y = y;
        }
    }


    /// <summary>
    /// This will require all instances of PointRef to be stack allocated
    /// </summary>
    public ref struct PointRef
    {
        public int X { get; }
        public int Y { get; }

        public PointRef(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
