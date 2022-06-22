using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class Partition : IFunction
    {

        public static int Part(List<float> a, int start, int end)
        {
            float pivot = a[start];
            int i = start;
            int j = end;
            while (true)
            {
                do
                {
                    i++;
                } while (a[i] < pivot);

                do
                {
                    j--;
                } while (a[j] > pivot);

                if (i >= j)
                {
                    return j;
                }
                var temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }
              return j;
        }

        // Routine de tri rapide

        static void QuickSort(List<float> a, int low, int high)

        {
            // condition de base
            if (low >= high)
            {
                return;
            }
            // réarrange les éléments sur le pivot
            int pivot = Part(a, low, high);
            // se reproduit sur le sous-tableau contenant des éléments inférieurs au pivot
            QuickSort(a, low, pivot);
            // se reproduisent sur le sous-tableau contenant des éléments qui sont plus que le pivot
            QuickSort(a, pivot + 1, high);
        }
        public float Apply(List<BasicNumber> arguments)
        {
            short start = (short)arguments[0].GetValue();
            short end = (short)arguments[1].GetValue();
            List<float> Liste = new List<float>();
            for(short x = start; x < end; x++)
            {
                Liste.Add(Memory.MemoryGet(x));
            }
            QuickSort(Liste, start, end);
            int cpt = 0;
            for(short x = start; x < end; x++)
            {
                Memory.MemorySet(x, Liste[cpt]);
                cpt++;
            }
            return 0;
        }
    }
}
