using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Question6
    {
        public void Runner()
        {
            ArrayList arrayList = new ArrayList();
            Stopwatch swArrayList = new Stopwatch();

            List<int> list = new List<int>();
            Stopwatch swList = new Stopwatch();


            long sum1 = 0;
            long sum2 = 0;

            long memBeforeArrList = GC.GetAllocatedBytesForCurrentThread();
            swArrayList.Start();
            for (int i = 1; i < 5000000; i++) 
            { 
                arrayList.Add(i);
            }
            long memAfterArrList = GC.GetAllocatedBytesForCurrentThread();
            long memForArrList = memAfterArrList - memBeforeArrList;
            Console.WriteLine("Memory required to arrayList = " + memForArrList);

            for(int i = 0; i < arrayList.Count; i++)
            {
                sum1 += (int)arrayList[i];
            }
            swArrayList.Stop();
            Console.WriteLine("Arraylist Sum = " + sum1 + ", Time required = " + swArrayList.ElapsedMilliseconds);

            swList.Start();
            long memBeforeList = GC.GetAllocatedBytesForCurrentThread();
            for (int i = 1; i < 5000000; i++)
            {
                list.Add(i);
            }

            long memAfterList = GC.GetAllocatedBytesForCurrentThread();
            long memForList = memAfterArrList - memBeforeArrList;
            Console.WriteLine("Memory required to List = " + memForList);


            for (int i = 0; i < arrayList.Count; i++)
            {
                sum2 += list[i];
            }
            swArrayList.Stop();
            Console.WriteLine("List Sum = " + sum1 + ", Time required = " + swList.ElapsedMilliseconds);
        }

    }
}
