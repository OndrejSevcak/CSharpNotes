using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    //Same as ICollection with additional method using indexes like Insert(int index, Car item) or RemoveAt(int index)
    public class MyList : IList<Car>
    {
        public Car this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Car item) => throw new NotImplementedException();

        public void Clear() => throw new NotImplementedException();

        public bool Contains(Car item) => throw new NotImplementedException();

        public void CopyTo(Car[] array, int arrayIndex) => throw new NotImplementedException();

        public IEnumerator<Car> GetEnumerator() => throw new NotImplementedException();

        public int IndexOf(Car item) => throw new NotImplementedException();

        public void Insert(int index, Car item) => throw new NotImplementedException();

        public bool Remove(Car item) => throw new NotImplementedException();

        public void RemoveAt(int index) => throw new NotImplementedException();

        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
    }
}
