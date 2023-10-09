using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    //Helper class for IEnumerable
    public class MyEnumerator : IEnumerator<Car>
    {
        //Props
        public Car Current => throw new NotImplementedException();  //Cursor
        object IEnumerator.Current => throw new NotImplementedException();

        //Methods
        public void Dispose() => throw new NotImplementedException();
        public bool MoveNext() => throw new NotImplementedException();  //Move to the next items
        public void Reset() => throw new NotImplementedException();     //Go to start - first item
    }

    //With IEnumerable we can loop(enumerate) the collection item by item, but can not access items by index
    public class MyEnumerable : IEnumerable<Car>
    {
        public IEnumerator<Car> GetEnumerator() => throw new NotImplementedException();
        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
        
    }   
}
