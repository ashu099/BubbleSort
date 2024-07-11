using System;

namespace ConsoleApp1
{
    class Test
    {

        int k, ptr,temp;
        int[] arr = { 23, 12, 45, 34, 42, 67, 87, 65, 90, 84 };
       
        public void Swap()
        {
            Console.WriteLine("before sorting");
            for (int i = 0; i < arr.Length; i++) //length =10
            {
               
                Console.WriteLine(arr[i]);
            };
            for (int i = 0; i < arr.Length-1-1; i++)//length=8
            {
                ptr = 0;
                while (ptr<=(arr.Length-i-1-1))//first length =8, then 7,6,5,4,3,2,1
                {
                    if (arr[ptr]>arr[ptr+1])
                    {
                        temp = arr[ptr];
                        arr[ptr] = arr[ptr + 1];
                        arr[ptr + 1] = temp;
                    }
                    ptr++;

                }
            }
            //a = a * b;
            //b = a / b;
            //a = a / b;
            Console.WriteLine("after sorting");
            for (int i = 0; i < arr.Length; i++)
            {
              
                Console.WriteLine(arr[i]);
            };

        }
        public static void Main()
        {
           
            Test t = new Test();
            t.Swap();
        }

    }
}
