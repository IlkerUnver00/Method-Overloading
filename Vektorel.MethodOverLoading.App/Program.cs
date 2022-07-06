using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.MethodOverLoading.App
{
    class Program
    {
        static void Main(string[] args)
        {
            float d = Toplama(10.3f, 2);
            
        }



        static double Toplama(double a,double b)
        {
            return a + b;
        }

        static float Toplama(float a,float b)
        {
            return a + b;
        }


    }
}
