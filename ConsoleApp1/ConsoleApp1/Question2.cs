using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Question2
    {
        public void SwapNoRef(int[] a, int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }

        public void SwapWithRef(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }

        public void SwapFirst(int[] a, int[] b)
        {
            int temp = a[0];
            a[0] = b[0];
            b[0] = temp;
        }

        public void Runner()
        {
            int[] x = { 1, 2, 3 };
            int[] y = { 7, 8, 9 };

            Console.WriteLine("before swap :");
            Console.WriteLine("x = " + string.Join(',',x));
            Console.WriteLine("y = " + string.Join(',', y));

            SwapNoRef(x, y);

            Console.WriteLine("after swap with no referance:");
            Console.WriteLine("x = " + string.Join(',', x));
            Console.WriteLine("y = " + string.Join(',', y));

            SwapWithRef(ref x, ref y);

            Console.WriteLine("after swap with referance:");
            Console.WriteLine("x = " + string.Join(',', x));
            Console.WriteLine("y = " + string.Join(',', y));

        }
    }

}
