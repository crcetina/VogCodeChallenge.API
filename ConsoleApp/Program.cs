using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        //program Iterate list without using ForEach/For loops
        static void Main(string[] args)
        {


            Console.WriteLine("Iterate list \n");
            int count = 0;
            Console.WriteLine("**********************BEGIN************************");
            while (count != QuestionClass.NamesList.Count)
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


    public class TEST
    {
        public  string TESTModule(object value)
        {
            string result = string.Empty;
            try
            {                
                if (value != null)
                {
                    Type TO = value.GetType();
                    switch (TO.Name)
                    {
                        case "Int32":
                            if ((Int32)value < 1)
                            {
                                result = "Error: you cannot perform operations with the value less than 1";
                                //throw new Exception("Error: you cannot perform operations with the value less than 1");
                               
                            }
                            if ((Int32)value >= 1 && (Int32)value <= 4)
                            {
                                result = ((Int32)value * 2).ToString();                                
                                break;
                            }
                            if ((Int32)value >= 4)
                            {
                                result = ((Int32)value * 3).ToString();
                                break;
                            }

                            break;
                        case "Single":
                            if ((float)value == 1.0f || (float)value == 2.0f)
                            {
                                result = "3.0f";
                            }
                            break;
                        case "String":
                            result = value.ToString().ToUpper();
                            break;
                        default:
                            result =  value.ToString();
                            break;
                    }
                    
                }
                else
                {
                    throw new Exception("Error TESTModule: value null");
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error TESTModule: " + ex.Message);
            }
            return result;
        }

    }
}
