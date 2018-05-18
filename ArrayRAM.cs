using System;

namespace ConsoleApplication1
{
    internal class ArrayRAM : Array
    {
        public readonly int[] Data;

        public ArrayRAM(int count, int seed)
        {
            Data = new int[count];
            Length = count;
            var rand = new Random(seed);

            for (var i = 0; i < count; i++)
            {
                Data[i] = rand.Next(Sort.maxValue);
            }
        }

        public override int this[int index]
        {
            get => Data[index];
            set => Data[index] = value;
        }
    }
}