using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iseseisevtöö_3variant
{
    class iseseisevtoo_3variant
    {
        public static void Main(string[] args)
            
        {
            //var array = new decimal[8];
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.Write("sissestage {0} arv : ", i + 1);
            //    array[i] = Convert.ToDecimal(Console.ReadLine());
            //}

            //var max = array[0];
            //var min = array[0];
            //for (int i = 1; i < 8; i++)
            //{
            //    if (array[i] < min) min = array[i];
            //    if (array[i] > max) max = array[i];
            //}

            //Console.WriteLine("erinevus vahel maksimaalsest ja minimaalsest = {0}", max - min);








            //int[] array1 = new int[125];

            //Random rand = new Random();
            //int k = 0;
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    array1[i] = rand.Next(250);
            //    Console.WriteLine(array1[i]);
            //}
            //foreach (int chislo in array1)
            //{
            //    if (chislo < 125)
            //    {
            //        k++;
            //    }

            //}
            //Console.WriteLine("kokku:{0}", k);














            Random rnd = new Random();
            Console.WriteLine("How many children play?");
            try
            {
                int ustalja = 0;
                List<int> LapsedList = new List<int>();
                List<int> LapsedList2 = LapsedList.ToList();
                int howmany = int.Parse(Console.ReadLine());
                Console.Write("Childrens: ");
                for (int i = 0; i < howmany; i++)
                {
                    LapsedList.Add(i);
                }
                foreach (int item in LapsedList)
                {
                    Console.Write("{0} ", item);
                }
                int step = rnd.Next(1, 5);
                Console.WriteLine("step: {0}", step);
                int lengthlapsed = LapsedList.Count;
                int lengthlapsed2 = 0;


                while (lengthlapsed > 1)
                {
                    lengthlapsed -= 1;
                    lengthlapsed2 = lengthlapsed;
                    for (int i = 0; i < lengthlapsed + 1; i++)
                    {
                        LapsedList[i] = i;
                    }
                    LapsedList2 = LapsedList;

                    while (step > lengthlapsed2)
                    {
                        LapsedList2 = LapsedList.Concat(LapsedList2).ToList();

                        lengthlapsed2 += lengthlapsed;
                    }

                    ustalja = LapsedList2[step - 1];
                    LapsedList.RemoveAt(ustalja);
                    Console.WriteLine(" i delete {0}", ustalja);
                    step += (step - 1);
                    foreach (int item in LapsedList)
                    {
                        Console.Write(item);
                    }
                }
                foreach (int item in LapsedList)
                {
                    Console.WriteLine("last is " + item);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Viga!");
            }
        }
    }

}
