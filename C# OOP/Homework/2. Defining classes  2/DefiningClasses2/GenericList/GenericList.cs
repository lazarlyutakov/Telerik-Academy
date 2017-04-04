using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
   public class GenericList<T>
        where T : IComparable
    {
        private T[] listOfElements;
        private const int fixedDefaultCapacity = 3;
        private int elementsCount = 0;
        private int index;

        public int Count { get { return elementsCount; } }


        public GenericList(int capacity)
        {
            listOfElements = new T[capacity];
        }

        public GenericList()           
        {
            this.listOfElements = new T[fixedDefaultCapacity];
            this.index = -1;
        }


        public T this[int index]
        {
            get
            {
                return this.listOfElements[index];
            }
            set
            {
                if (this.index < 0 || this.index > this.listOfElements.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                this.listOfElements[index] = value;
            }
        }

        public void Add(T element)
        {
            this.elementsCount++;

            if (elementsCount == listOfElements.Length)
            {
                this.ExpandDouble();
            }
            this.listOfElements[this.elementsCount] = element;
        }


        public void RemoveAtPsn(int index)
        {
            if(index < 0 || index >= listOfElements.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                T[] newListOfElements = new T[listOfElements.Length];

                for (int i = 0; i < index; i++)
                {
                    newListOfElements[i] = listOfElements[i];
                }
                for (int i = index + 1; i < elementsCount; i++)
                {
                    newListOfElements[i - 1] = listOfElements[i];
                }

                listOfElements = newListOfElements;
                elementsCount--;
            }
        }


        public void InsertAtPsn(int index, T value)
        {
            if(index == listOfElements.Length)
            {
                ExpandDouble();
            }

            if(index < 0 || index > elementsCount)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                T[] newListOfElements = new T[listOfElements.Length];

                for (int i = 0; i < index; i++)
                {
                    newListOfElements[i] = listOfElements[i];
                }

                newListOfElements[index] = value;

                for (int i = index ; i < elementsCount; i++)
                {
                    newListOfElements[i + 1] = listOfElements[i];
                }

                listOfElements = newListOfElements;
                elementsCount++;
            }
        }


        public void ClearList()
        {
            var clearedList = new T[0];
            listOfElements = clearedList;
        }

        public int FindElementByValue(T value)
        {
            int indexOfElement = int.MinValue;

            for (int i = 0; i < listOfElements.Length; i++)
            {
                if(value.ToString() == listOfElements[i].ToString())
                {
                    indexOfElement = i;
                    break;
                }
            }
            return indexOfElement;
        }

        public override string ToString()
        {
            StringBuilder convertToString = new StringBuilder();

            foreach (var element in listOfElements)
            {
                convertToString.Append(element + " ");
                convertToString.Append("\r\n");
            }
            return convertToString.ToString();
        }

        private void ExpandDouble()
        {
            var newElements = new T[2 * listOfElements.Length];

            for (var i = 0; i < listOfElements.Length; i++)
            {
                newElements[i] = this.listOfElements[i];
            }
            this.listOfElements = newElements;
        }

        public T MinValue()
        {
            T minValue = listOfElements[0];

            for (int i = 0; i < elementsCount; i++)
            {
                if((dynamic)minValue > (dynamic)listOfElements[i])
                {
                    minValue = listOfElements[i];
                }
            }
            return minValue;
        }

        public T MaxValue()
        {
            T maxValue = listOfElements[0];

            for (int i = 0; i < elementsCount; i++)
            {
                if ((dynamic)maxValue < (dynamic)listOfElements[i])
                {
                    maxValue = listOfElements[i];
                }
            }
            return maxValue;
        }

        
    }
}
