using System;

using static System.Console ;

//
namespace ConsoleApp1
{//Single line comment
    
    /* multi line comments
     * */
    //class name
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World!");//end with new line
             WriteLine("*************************");
             Write("hellohello");//same line 
             WriteLine("123123123");//same line
             String name = "priya";

             Write("****"+name+"*******");

             int number = 7;

             if (number % 2 == 0)
             {
                 WriteLine("even");
             }
             else 
             {
                 WriteLine("odd");
             }

             for (int i = 0; i < 5; i++)
             {
                 writeNew("%%%%");
             }
             int j = 0;
             while (j < 5)
             {
                 WriteLine("^^^^^^^");
                 j++;
             }

            */


            WriteLine("Lect2,Demo1: getting user input...");
            Write("Please write your name:");
            string userName = ReadLine();
            Write("Please enter your department name:");
            string departmentName = ReadLine();

            Write("Please enter your faculty name:");
            string faculty = ReadLine();

            //first paramter is value of the output,second paramter is number of times it gets created
            String asterikLine = new string('*', 64);

            WriteLine(asterikLine);
            WriteLine("*{0,20}: {1,-40}*", "Name", userName);
            WriteLine("*{0,20}: {1,-40}*", "Department", departmentName);
            WriteLine("*{0,20}: {1,-40}*", "faculty", faculty);
            WriteLine(asterikLine);
        }

        static void writeStar()
         {
             WriteLine("***************************");
         }
        
        
    }
}
