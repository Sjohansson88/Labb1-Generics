using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Generics
{
    internal class BoxCollection : ICollection<Box>
    {
        private List<Box> innerCollection;

        public BoxCollection()
        {
            innerCollection = new List<Box>();
        }
        public bool IsReadOnly { get { return false; } }


        public Box this[int index]
        {
            get { return (Box)innerCollection[index]; }
            set { innerCollection[index] = value; }
        }
        public void Add(Box item)
        {
            if (!Contains(item))
            {
                innerCollection.Add(item);
            }
            else
            {
                Console.WriteLine("This Box is already exist");
            }
        }



        public bool Contains(Box item)
        {
            bool found = false;
            foreach (Box b in innerCollection)
            {
                if (b.Equals(item))
                {
                    found = true;
                }
            }
            return found;
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        public bool Remove(Box item)
        {
            bool result = false;
            for (int i = 0; i < innerCollection.Count; i++)
            {
                Box currentBox = innerCollection[i];
                if (new BoxSameProp().Equals(currentBox, item))
                {
                    innerCollection.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        public int Count
        {
            get
            {
                return innerCollection.Count;
            }
        }

        public void Clear()
        {
            innerCollection.Clear();
        }

    }
}
