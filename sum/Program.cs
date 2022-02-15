using System;

namespace HomeTask
{
    class Program
    {
        static void Main(string[] args)

        #region Practice
        //Console.WriteLine("Hello World!");


        //int[] arr = { 5, 10, 15, 18, 20, 25, 30, 15, 5 };
        //Console.WriteLine(Array.IndexOf(arr,18));
        //Console.WriteLine(Array.LastIndexOf(arr,5));

        //int num1 = Array.Find(arr, x => x == 50);
        //Console.WriteLine(num1);

        //int[] num2 = Array.FindAll(arr, x => x == 5);
        //foreach (int number in num2)
        //{
        //    Console.WriteLine(number);
        //}

        //bool result = Array.Exists(arr, x => x == 21);
        //if (result)
        //{
        //    Console.WriteLine("yes");
        //}
        //else
        //{
        //    Console.WriteLine("no");
        //}
        #endregion
        {
            int[] arr = { 40, 50, 60, 70, 90, 100 };
            int count;
            int total = Totalpoint(arr, out count);
            int avarage = Avarage(total, count);
            Console.WriteLine(avarage);
        }

        public static int Totalpoint(int[] arr, out int count)
        {
            count = arr.Length;
            int total = 0;
            foreach (int num in arr)
            {
                total += num;
            }
            return total;
        }

        public static int Avarage(int total, int count)
        {
            int avarage = total / count;
            return avarage;
        }

    }
}
            
        

        

             
        
        


