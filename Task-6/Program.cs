using System;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a program in C# sort array both descending and ascending order
            // DescAndAsc();

            // 2. Write a C# program to find the 3rd max element of array.
            // Find3rd();

            // 3. Write a program in C# to find first 4 max elements.
            // ForMax();

            // 4. Write a program in C# to create a function to swap the values of two integer numbers without additional variable.
            // Test Data : Enter a number: 5 Enter another number: 6 Expected Output : Now the 1st number is : 6 , and the 2nd number is : 5
            // SwaptheValues();


            // 5. Write a program in C# to create a function to display the n number Fibonacci sequence.
            // Test Data : Input number of Fibonacci Series : 5 Expected Output : The Fibonacci series of 5 numbers is : 0 1 1 2 3 5 8
            // FibonacciSeries();


            // 6. Write a program in C# to create a function to calculate the sum of the individual digits of a given number.
            // Test Data : Enter a number: 1234 Expected Output : The sum of the digits of the number 1234 is : 10
            // ReqemleriTopla();
        }

        static void DescAndAsc()
        {
            int[] ascendingArray = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] descendingArray2 = new int[] { 6, 5, 4, 3, 2, 1 };
        }

        static void Find3rd()
        {
            int[] number = new int[] { 1, 2, 3, 4, 5, };
            string three = number[2].ToString();
            Console.WriteLine(three);

            string[] names = new string[] { "azer", "araz", "turxay", "tamerlan", "kamran" };
            string nameThree = names[2];
            Console.WriteLine(nameThree);

        }

        static void ForMax()
        {
            int[] number = new int[] { 1, 2, 3, 4, 5, };

            for (int i = 0; i <=3; i++)
            {
                Console.WriteLine(number[i]);
            }

            Console.WriteLine("**************************************************************************");

            string[] names = new string[] { "azer", "araz", "turxay", "tamerlan", "kamran" };
            for (int y = 0; y <=3; y++)
            {
                Console.WriteLine(names[y]);
            }

        }
        static void SwaptheValues()
        {
            Console.WriteLine("Birinci reqemi daxil edin");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ikinci reqemi daxil edin");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"a={a} b={b}");

            a = a+b;
            b = a-b;
            a= a-b;

            Console.WriteLine($"swap the values; a={a} b={b}");

        }

        static void FibonacciSeries()
        {


            int a = 0;
            int b = 1;
            int c = 0;
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Netice: ");
            Console.WriteLine("0");

            for (int i = 0; i <d; i++)
            {

                Console.WriteLine(b);
                c = a + b;
                a = b;
                b = c;


            }
        }

        static void ReqemleriTopla()
        {
            Console.Write("Bir reqem daxil edin : ");

            int reqem = Convert.ToInt32(Console.ReadLine());

            int top = 0;
            while (reqem > 0)
            {
                
                int saylar = reqem % 10;
                top = top+saylar;
                reqem = reqem/10;  

            }
            Console.WriteLine("*****************************");
            Console.WriteLine($"Bu ededin pillelerinin reqemlerinin cemi :  {top}");




        }
    }
}
