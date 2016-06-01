using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHashSet
{
    class LisHash
    {
        static void Main(string[] args)
        {
            
            
            int [] Myarray = new int[100000];
            Stopwatch StWatch = new Stopwatch();
            Random RanT = new Random();
            List<int> Lisran = new List<int>();
            HashSet<int> HashNumbers = new HashSet<int>();

            StWatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                int Rand = (int)(RanT.Next(1000, 10000));
                Myarray[i] = Rand;
            }
            StWatch.Stop();
            Console.WriteLine("you spent {0}", StWatch.ElapsedMilliseconds);
            Console.ReadLine();

            StWatch.Start();
            for (int counter = 0; counter < 10000; counter++)
            {
                
                HashNumbers.Add(Myarray[counter]);
                Lisran.Add(Myarray[counter]);
            }
            StWatch.Stop();
            Console.WriteLine("It tooks: ", StWatch.ElapsedMilliseconds);
            Console.WriteLine();

            StWatch.Start();
            for (int k = 0; k < 1000; k++)
            {
                if (Lisran[k] < 5000)
                {
                    Console.WriteLine(k);
                }

            }
            StWatch.Stop();
            Console.WriteLine("Time taken is: ", StWatch.ElapsedMilliseconds);
            Console.WriteLine();


            StWatch.Start();
            int r =0;
            foreach (int i in HashNumbers)
            {
                if (HashNumbers.Contains(i))
                {
                    r++;
                    if (r <= 1000)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            StWatch.Stop();
            Console.WriteLine("you spent {0}", StWatch.ElapsedMilliseconds);
            Console.ReadLine();






        }
    }
}


