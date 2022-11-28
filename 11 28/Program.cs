using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_28
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rendezés
            int[] tomb = new int[]{3,4,1};
            for (int j = 0; j < tomb.Length-1; j++)
			{
                int min = j;
                for (int i = j+1; i < tomb.Length; i++)
			    {
                    if (tomb[min]> tomb[i])
	                {
                        min = i;
	                }
			    }
                int temp = tomb[min];
                tomb[min]= tomb[j];
                tomb[j]= temp;
			}
            foreach (var szam in tomb)
	        {
                Console.WriteLine(szam);
	        }

            Console.ReadKey();
        }
    }
}
