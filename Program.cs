using System.Diagnostics.CodeAnalysis;

namespace CSharpfundamentals.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////Task one 
            //Console.WriteLine("Enter first number: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number: ");
            //int number2 = int.Parse(Console.ReadLine());
            //int sum = number1 + number2; 
            //Console.WriteLine($"the sum of {number1} and {number2} is: {sum}");

            //int multiply = number1 * number2;
            //Console.WriteLine($"the multiply of {number1} and {number2} is: {multiply}");

            //double divid = number1 / number2;
            //Console.WriteLine($"the divid  of {number1} and {number2} is: {divid}");


            //Task Two

            //int x = -1, y = 4, z = 6; 
            //Console.WriteLine($"The value = {x+y*z}");   //23

            //int x = 35, y = 5, z = 7;
            //Console.WriteLine($"The value = {(x + y) % z}");   //5

            //double x = 14, y = -4, z = 6, w=11;
            //Console.WriteLine($"The value = {x + -y*z/w}");   //16.18181818181818

            //double x = 2, y = 15, z = 6, w=1, e=7, r=2;
            //Console.WriteLine($"The value = {x + y/z*w-e%r}");   //3.5

            //int x = 10; 
            //Console.WriteLine($" z = {(x++)+x} ");     //21


            //Task Three 

            int age;
            do
            {
                Console.WriteLine("please enter your age: ");
                age = int.Parse(Console.ReadLine());    
            }while (age<18 || age>25);

            Console.WriteLine("you can use the application");







//            year();
//            month();
//            day();
             

       }


//        static void year ()

//        {
//            Console.WriteLine("pls enter year");
//            string years = Console.ReadLine();
//            int intYear = int.Parse(years);
//            Console.WriteLine($"you are { 2023 - intYear} years");
             
//        }
//        static void month()

//        {
//            Console.WriteLine("pls enter month");
//            string months = Console.ReadLine();
//            int intMonth = int.Parse(months);
//            Console.WriteLine($"{12 - intMonth} months");

//        }
//        static void day()

//        {
//            Console.WriteLine("pls enter day");
//            string days = Console.ReadLine();
//            int intDay = int.Parse(days);
//            Console.WriteLine($"{30 - intDay} days");
        //}
    }
}