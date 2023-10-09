using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    //Use ICollection when you need actions like adding, removing items or knowing how many items the collection has
    //Still can not access item by index
    public class MyCollection : ICollection<Car>
    {
        public int Count => throw new NotImplementedException();    //ICollection knows how many items it has
        public bool IsReadOnly => throw new NotImplementedException();


        //Methods - a lot more than IEnumerable
        public void Add(Car item) => throw new NotImplementedException();

        public void Clear() => throw new NotImplementedException();

        public bool Contains(Car item) => throw new NotImplementedException();

        public void CopyTo(Car[] array, int arrayIndex) => throw new NotImplementedException();

        public IEnumerator<Car> GetEnumerator() => throw new NotImplementedException();

        public bool Remove(Car item) => throw new NotImplementedException();

        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
    }
}
