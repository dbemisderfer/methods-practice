using System;

namespace MethodsPractice
{
    class MainClass
    {
        //public static void GreetFriend(string friendName)
        //{
        //    Console.WriteLine("Hi " + friendName + ", my friend!"); 
        //}
        //public static int addNums(int num1, int num2)
        //{
        //    return num1 + num2;
        //}
        public static void Main(string[] args)
        {
            //string friend1 = "Matt";
            //string friend2 = "Jere";
            //string friend3 = "Linn";
            //GreetFriend(friend1);
            //GreetFriend(friend2);
            //GreetFriend(friend3);
            //Console.WriteLine("Please enter two numbers to add together.");
            //Console.Write("First number: ");
            //string input1 = Console.ReadLine();
            //Console.Write("Second number: ");
            //string input2 = Console.ReadLine();
            //Console.WriteLine("The sum of {0} and {1} is: {2}", input1, input2, addNums(int.Parse(input1), int.Parse(input2)));

            //Console.Write("Please enter a number to be divided by 0! : ");
            //string input = Console.ReadLine();
            //try
            //{
            //    int num = int.Parse(input);
            //    int answer = num / 0;
            //    Console.WriteLine("{0} divided by zero is: {1}", num, answer);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Sorry, you must enter a whole integer.");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("You can't divide by zero(0), you idiot!!!");
            //}
            //finally
            //{
            //    Console.WriteLine("Man, you're really stupid.");
            //}

            int num1 = 5;
            int num2 = 3;
            bool isHigher;
            isHigher = num1 > num2;
            Console.WriteLine("Result of {0} > {1} is {2}", num1, num2, isHigher);

            
        }
    }
}
