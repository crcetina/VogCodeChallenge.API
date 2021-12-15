using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Iterate list \n");
            int count = 0;
            Console.WriteLine("**********************BEGIN************************");
            while (count!= QuestionClass.NamesList.Count)
            {
                Console.WriteLine(QuestionClass.NamesList[count]);
                count++;
            }
            Console.WriteLine("**********************FINISH************************");
            Console.WriteLine("\n Iterate Finish");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();




        }



    }
    public static class QuestionClass
    {
        public static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffrey",
            "John",
        };
    }
}
