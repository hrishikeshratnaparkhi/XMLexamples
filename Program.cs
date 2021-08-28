using System;

namespace DekegateEvent
{
    class Multicasteample
    {
        public delegate void mydelegate(int i, int j);

        public void Add(int i, int j)
        {
            Console.WriteLine(i + j);

        }
        public void Mul(int i, int j)
        {
            Console.WriteLine(i * j);

        }
        class Mulcastdelegate
        {
            public static void Main(string[] args)
            {
                Multicasteample me = new Multicasteample();
                Multicasteample.mydelegate mydelegateintance = null;

                mydelegateintance += new Multicasteample.mydelegate(me.Add);
                mydelegateintance -= new Multicasteample.mydelegate(me.Mul);

                mydelegateintance(10, 10);
                mydelegateintance(2, 10);

                


            }
                
        }



    }
    
}
