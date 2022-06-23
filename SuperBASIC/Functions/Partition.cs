using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    public class Partition : IFunction
    {

        public static short Part(int start, int end)
        {
           // start = (short)start;
            short pivot = (short)Memory.MemoryGet((short)start);
            int i = start - 1;
            int j = end + 1;
            while (true)
            {
                do
                {
                    i++;
                } while (Memory.MemoryGet((short)i) < pivot);

                do
                {
                    j--;
                } while (Memory.MemoryGet((short)j) > pivot);

                if (i >= j)
                {
                    return (short)j;
                }
                var temp = Memory.MemoryGet((short)i);
                Memory.MemorySet((short)i, Memory.MemoryGet((short)j));
                Memory.MemorySet((short)j, temp);
            }
              return (short)i;
        }

        // Routine de tri rapide

        static void QuickSort(int low, int high)

        {
            // condition de base
            if (low >= high)
            {
                return;
            }
            // réarrange les éléments sur le pivot
            int pivot = Part(low, high);
            // se reproduit sur le sous-tableau contenant des éléments inférieurs au pivot
            QuickSort(low, pivot);
            // se reproduisent sur le sous-tableau contenant des éléments qui sont plus que le pivot
            QuickSort(pivot + 1 , high);

        }
        public float Apply(List<BasicNumber> arguments)
        {
            short start = (short)arguments[0].GetValue();
            short end = (short)arguments[1].GetValue();

            QuickSort((int)start, (int)end);
            
            for (short x = start; x <= end; x++)
            {
                Console.WriteLine("Mem: {0}", Memory.MemoryGet(x));
            }
            return 0f;
        }
    }
}
