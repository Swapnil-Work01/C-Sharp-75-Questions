using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Question1
    {
        public void MoveS(PointS p)
        {
            p.x += 10;
        }

        public void MoveC(PointC p) {
            p.x += 10;
        }

        public void Runner()
        {
            PointS s1 = new PointS();
            s1.x = 1;
            s1.y = 2;

            PointC c1 = new PointC();
            c1.x = 1;
            c1.y = 2;

            Console.WriteLine("struct : x = " + s1.x + " y = " + s1.y + " class : x = " + c1.x + " y = " + c1.y);

            MoveS(s1);
            MoveC(c1);

            Console.WriteLine("struct : x = " + s1.x + " y = " + s1.y + " class : x = " + c1.x + " y = " + c1.y);

            //Changing a struct parameter inside a method never reaches the caller unless you pass it with ref
            var s2 = s1;
            var c2 = c1;
            s2.y = 99;
            c2.y = 99;
            Console.WriteLine("s2.y = " + s1.y+ " c2.y = " + c1.y);
        }


    }

    public struct PointS
    {
        public int x, y;
    }

    public class PointC
    {
        public int x, y;
    }
}
