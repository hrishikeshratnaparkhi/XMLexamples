using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegateexp
{
    class Class1
    {
        public delegate void mygenericDelegate<y>(y arg);

        public void genDelMethod()
        {
            Console.WriteLine("generic ///////////");
            mygenericDelegate<string> strTarget = new mygenericDelegate<string>(StingTarget);
            strTarget("some string data");

            mygenericDelegate<int> intTarget = IntTarget;
            intTarget(9);
            Console.ReadLine();

        }
        public void StringTarget(string arg)
        {
            Console.WriteLine("arge in uppercaseis : {0}", arg.ToUpper());

        }
        public void IntTarget(int arg)
        {
            Console.WriteLine("arge in uppercaseis : {0}", ++arg);

        }
    }
    class genericDelegateex
    {
       public static void Main()
        {
            Class1 ob = new Class1();
            ob.IntTarget(10);
        }
    }


    
}
