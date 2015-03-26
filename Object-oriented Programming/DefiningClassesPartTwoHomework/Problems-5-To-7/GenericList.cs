using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_5_To_7
{
    public class GenericList<T>
    {
        // constants
        private const int InitialCapacity = 4; //8;

        // fields
        private T[] listArr;
        private int count;
        private int currentIndex = 0;

        // constructors
        public GenericList()
        {
            this.listArr = new T[InitialCapacity];
            this.count = 0;
            this.currentIndex = 0;
        }

        public GenericList(int arrCapacity)
        {
            if (arrCapacity <= InitialCapacity)
            {
                this.listArr = new T[InitialCapacity];
            }
            else
            {
                this.listArr = new T[arrCapacity];
            }

            this.count = 0;
            this.currentIndex = 0;
        }

        // properties

        // returns the actual number of elements of the list
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        // returns the capacity of the list
        public int Capacity
        {
            get
            {
                return this.listArr.Length;
            }
        }

        // declare indexer
        public T this [int index]
        {
            get
            {
                if (index < 0 || index > count)
                {
                    throw new IndexOutOfRangeException("The index you're looking for is out of the range of the GenericList<T>");
                }

                return this.listArr[index];
            }
            set
            {
                if (index < 0 || index > count)
                {
                    throw new IndexOutOfRangeException("The index you're looking for is out of the range of the GenericList<T>");
                }

                this.listArr[index] = value;
            }
        }

        // class methods

        // adding new element at the end of the list
        public T[] AddElement(T element)
        {
            if (count + 1 > this.Capacity)
            {
                ResizeArr(this.Capacity * 2); //!?!   
            }

            this.listArr[currentIndex] = element;
            currentIndex++;
            count++;

            return listArr;
        }

        // if the number of elements we have in the list is >= Capacity, we invoke this method the resize the array
        private T[] ResizeArr(int newCapacity)
        {
            T[] extendedList = new T[newCapacity];
            Array.Copy(listArr, extendedList, newCapacity - count);
            listArr = extendedList;

            return listArr;
        }

        // accessing the element at a specified position of the array
        public T AccessElementAt(int index)
        {
            if (index < 0 || index > this.count)
            {
                throw new IndexOutOfRangeException("The index you're looking for is out of the range of the GenericList<T>");
            }

            return this.listArr[index];
        }

        // removing the element at a specified position of the list
        public T RemoveElementAt(int index)
        {
            if (index < 0 || index > this.count)
            {
                throw new IndexOutOfRangeException("The index you're looking for is out of the range of the GenericList<T>");
            }

            T element = this.listArr[index];

            // rewriting the original array with a slight shift - in the copy -> listArr[index] = listArr[index + 1]
            Array.Copy(listArr, index + 1, listArr, index, count - index); // need to check it!

            // returning the default value to the last element of the list
            listArr[count - 1] = default(T);
            count--;
            currentIndex--;

            return element;
        }

        // inserting an element at a specified position of the list
        public T[] InsertElementAt(T element, int index)
        {
            if (index < 0 || index > this.count)
            {
                throw new IndexOutOfRangeException("The index you're looking for is out of the range of the GenericList<T>");
            }

            T[] extendedList = listArr;
            if (count + 1 > this.Capacity)
            {
                ResizeArr(this.Capacity * 2); // if it's working properly
            }

            Array.Copy(listArr, extendedList, index);
            count++;
            currentIndex++;
            Array.Copy(listArr, index, extendedList, index + 1, count - index - 1);
            extendedList[index] = element;
            listArr = extendedList;

            return this.listArr;
        }

        // clearing the current list
        public void Clear()
        {
            listArr = new T[InitialCapacity];
            count = 0;
        }

        // finding if the list we are working with contains a specified value and returns its index
        public int FindByValue(T element)
        {
            for (int i = 0; i < this.listArr.Length; i++)
            {
                if (element.Equals(listArr[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        // returns true if the list containts the element and false if it does not
        public bool ContainsElement(T element)
        {
            int index = FindByValue(element);
            if (index == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // converting the content of the current list to string so it would be easier to print it on the Console
        public override string ToString()
        {
            StringBuilder listSb = new StringBuilder();

            foreach (var element in listArr)
            {
                listSb.Append(element);
                listSb.Append(" ");
            }

            return listSb.ToString();
        }
    }
}
