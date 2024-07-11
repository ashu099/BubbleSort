using System;

namespace Test
{
    class Test
    {

        int a, b;
        public void Swap(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"{0},{1}", a, b);

        }
        public static void Main()
        {
            Test t = new Test();
            t.Swap(5, 6);
        }

    }
}