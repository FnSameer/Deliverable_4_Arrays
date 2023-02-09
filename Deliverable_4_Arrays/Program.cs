namespace Deliverable_4_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[25];


            //initialize fibonacci
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 0; i < 25; i ++)
            {
                if (i >= 2)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];

                }

                Console.WriteLine("Fibonacci number (" + i + ") = " + fibonacci[i]);

            }

           
        }
    }
}