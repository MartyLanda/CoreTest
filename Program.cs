using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ". Nice to meet you!");
            string strNum = "";
            decimal num = 0;
            while(decimal.TryParse(strNum, out num) != true) {
                Console.Write("Enter a Number I Can Multiply By 10: ");
                strNum = Console.ReadLine();                
            }
            num = Convert.ToDecimal(strNum) * 10;
            Console.WriteLine(strNum + " Times 10 = " + num);
        }
    }
}
