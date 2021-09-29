using System;

namespace EquilibriumIndex
{
    class Program
    {
        static int EquilibriumIndex(int[] a)
        {
            int retindex = -1;
            int sum = 0;
            //first calculate the sum of the array
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            //index is equilibrium if the sum of lower indices == sum of higher indices
            int leftsum = 0;
            for (int i = 0; i < a.Length; i++)

            {
                //sum includes the number at this index too- subtract and then continue to compare with the lower indices sum
                sum -= a[i];
                if (leftsum == sum)
                {
                    //found index return
                    retindex = i;
                    break;
                }
                //update left sum for the check for the next index
                leftsum += a[i];

            }
            return retindex;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = { 1, 3, 5, 2, 2 };

            Console.WriteLine("Equilibrium index of [1, 3, 5, 2, 2 ] is {0} ", EquilibriumIndex(a));
            Console.ReadLine();
        }
    }
}
