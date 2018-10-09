using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hinaliA2QA
{
    
public  class Program
    {
        TriangleSolver triangle = new TriangleSolver();
        static void Main(string[] args)
        {
            try
            {
                Program program_main = new Program();
                program_main.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        static bool ValidateInput(string input)
        {
            var a = input.ToCharArray();

            foreach (char c in a)
            {
                if (!char.IsDigit(c))
                {
                    Console.WriteLine("Invalid input..Please try again!");
                    return false;
                }
            }

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input..Please try again!");
                return false;
            }
            return true;
        }


        public void Run()
        {
            string str1, str2, str3;
            int int1, int2, int3;
            char choice;
            do
            {
                Console.WriteLine("\nMenu..........");
                Console.WriteLine("1. Enter triangle dimensions:");
                Console.WriteLine("2. Exit");
                Console.Write("Please Enter your choice:");
                choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        
                        case1: Console.Write("\n Enter 1st dimension: ");
                        str1 = Console.ReadLine();
                        if (!ValidateInput(str1))
                        {
                            goto case1;
                        }

                       case2:Console.Write("Enter 2nd dimension: ");
                        str2 = Console.ReadLine();
                        if (!ValidateInput(str2))
                        {
                            goto case2;
                        }

                        case3:Console.Write("Enter 3rd dimension: ");
                        str3 = Console.ReadLine();
                        if (!ValidateInput(str3))
                        {
                            goto case3;
                        }
                        int1 = int.Parse(str1);
                        int2 = int.Parse(str2);
                        int3 = int.Parse(str3);

                        if (int1 + int2 > int3 && int1 + int3 > int2 && int2 + int3 > int1)
                        {
                            string T = triangle.Analyze(int1, int2, int3);

                            Console.WriteLine("Type of Triandle: {0} triangle.", T);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("this is not the valid triangle.");
                            break;

                        }

                    case '2':
                        break;

                    default:
                        Console.WriteLine("\n Enter correct choice");
                        break;

                }
            } while (choice != '2');
        }
    }
}


