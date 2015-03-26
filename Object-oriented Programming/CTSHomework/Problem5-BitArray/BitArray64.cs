using System;
using System.Collections;
using System.Collections.Generic;

namespace Problem5_BitArray
{
    public class BitArray64 : IEnumerable<int>
    {
        // fields
        private ulong number;

        // constructors
        public BitArray64(ulong inputNumber)
        {
            this.Number = inputNumber;
        }

        // properties
        public ulong Number
        {
            get { return this.number; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The number cannot be null!");
                }

                if (value < 0 )
                {
                    throw new ArgumentException("We cannot have a negative number!");
                }

                this.number = value;
            }
        }

        // methods

        public IEnumerator<int> GetEnumerator()
        {
            int[] bitsArr = this.ConvertNumberToBitsArr();

            for (int i = 0; i < bitsArr.Length; i++)
            {
                yield return bitsArr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is BitArray64))
            {
                return false;
            }

            BitArray64 otherArr = obj as BitArray64;
            if (otherArr == null)
            {
                return false;
            }

            if (ReferenceEquals(this, otherArr))
            {
                return true;
            }

            return this.Number == otherArr.Number;
        }

        public static bool operator ==(BitArray64 firstArr, BitArray64 secondArr)
        {
            return firstArr.Equals(secondArr);
        }

        public static bool operator !=(BitArray64 firstArr, BitArray64 secondArr)
        {
            return !(object.Equals(firstArr, secondArr));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int this [int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new ArgumentException("The index was out of the range of the array!");
                }

                int[] numberWithBits = this.ConvertNumberToBitsArr();
                return numberWithBits[index];
            }
        }

        private int[] ConvertNumberToBitsArr()
        {
            int[] bitsArr = new int[64];

            ulong currentNum = this.number;
            int bitsCounter = 63;

            while (currentNum != 0)
            {
                int bit = (int)currentNum % 2;
                currentNum /= 2;

                bitsArr[bitsCounter] = bit;
                bitsCounter--;
            }

            while (bitsCounter != 0)
            {
                bitsArr[bitsCounter] = 0;
                bitsCounter--;
            }

            return bitsArr;
        }
    }
}
