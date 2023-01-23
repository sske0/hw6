using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

namespace hw6
{
    class Program
    {
        static void Main(string[] args)


        //1    
        //{
        //    Console.WriteLine("enter ur number: ");
        //    int number = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine(Divisionby7(number));




        //}

        //static int Divisionby7(int n)
        //{
        //if (n % 7 == 0)
        //{
        //    return n;
        //}
        //else if (n % 7 > 3)
        //{
        //    return (n + 3) / 7 * 7;
        //}
        //else
        //    {
        //        return n / 7 * 7;
        //    }


        //}


        //2 sum of numbers before the entered num
        //{ 
        //Console.WriteLine("enter ur number: ");
        //int number = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine( sumb4Num(number));
        //}

        //static int sumb4Num(int n)
        //{
        //    int sum = 0;
        //    n--; //remove this line incase you want the number to be included as well
        //   for(; n > 0; n--)
        //    {
        //        sum += n;
        //    }

        //    return sum;
        //}

        {
            Console.WriteLine("type the first line: ");
            string firststr = Console.ReadLine();
            Console.WriteLine("type the first line: ");
            string secondstr = Console.ReadLine();
            Findlongerstring(firststr,secondstr);
        }

        static void Findlongerstring(string str, string str1)
        {
            if (str.Length == str1.Length)
            {
                Console.WriteLine("lines are equal");
            }
            else if(str.Length > str1.Length)
            {
                Console.WriteLine("the first line is longer than the second");
            }
            else
            {
                Console.WriteLine("the second line is longer than the first");
            }

        }
}
}
