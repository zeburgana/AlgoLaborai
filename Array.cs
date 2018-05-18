﻿using System;

namespace ConsoleApplication1
{
    internal abstract class Array
    {
        public int Length;
        public abstract int this[int index] { get; set; }

        public void CopyTo(Array array, int index)
        {
            if (array.Length <= Length)
                for (var i = index; i < Length; i++)
                    array[i] = this[i];
            else
                throw new NotImplementedException();
        }

        public void Swap(int index1, int index2)
        {
            var temp = this[index1];
            this[index1] = this[index2];
            this[index2] = temp;
        }

        public void Print()
        {
            for (var i = 0; i < Length; i++)
            {
                Console.Write("{0:F5} ", this[i]);
            }

            Console.WriteLine();
        }

        public int GetMaxValue()
        {
            var max = 0;
            
            for (var i = 0; i < Length; i++)
            {
                if (this[i] > max)
                {
                    max = this[i];
                } 
            }

            return max;
        }
    }
}