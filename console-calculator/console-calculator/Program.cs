using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_calculator
{
    class Program
    {
        static double last_result = 0;

        static void Main(string[] args)
        {
            calculator();
        }

        static void menu(int position)
        {
            String[] output_menu = {
                                    " Console Calculator\n",
                                    " <1> : addition\n",
                                    " <2> : subtraction\n",
                                    " <3> : multiplication\n",
                                    " <4> : division\n",
                                    " <5> : power calculation\n",
                                    " <6> : square root\n",
                                    " <7> : factorial calculation\n",
                                    " <0> : exit\n\n"
                                    };

            String output_submenu = "   + more\n" +
                                    "     [A] : new\n" +
                                    "     [B] : last result + new\n" +
                                    "     [C] : exit function\n";

            for (int index = 0; index <= 8; index++)
            {
                Console.Write(output_menu[index]);
                if (position == 0) continue;
                else if(index == position)
                    Console.Write(output_submenu);
            }
        }

        static void calculator()
        {
            Boolean toContinue = true;
            do
            {
                Console.Clear();
                menu(0);

                String choice;
                Console.Write(" choose : ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        toContinue = false;
                        break;

                    case "1":
                        addition();
                        break;

                    case "2":
                        subtraction();
                        break;

                    case "3":
                        multiplication();
                        break;

                    case "4":
                        division();
                        break;

                    case "5":
                        power();
                        break;

                    case "6":
                        square_root();
                        break;

                    case "7":
                        factorial();
                        break;
                }
            } while (toContinue);
        }

        static void addition()
        {
            Boolean toContinue = true;
            do
            {
                Console.Clear();
                menu(1);

                String choice;
                Console.Write(" choose : ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "a":
                    case "A":
                        addition_new();
                        Console.ReadKey();
                        break;

                    case "b":
                    case "B":
                        addition_last_result();
                        Console.ReadKey();
                        break;

                    case "c":
                    case "C":
                        toContinue = false;
                        break;
                }
            } while (toContinue);
        }

        static void addition_new()
        {
            double x, y;

            Console.WriteLine();

            Console.Write(" input x : ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write(" input y : ");
            y = Convert.ToDouble(Console.ReadLine());

            double result = x + y;

            Console.WriteLine();

            Console.WriteLine(" result : " + x + " + " + y + " = " + result);
            last_result = result;
        }

        static void addition_last_result()
        {
            double y;

            Console.WriteLine();

            Console.Write(" input x : " + last_result);

            Console.WriteLine();

            Console.Write(" input y : ");
            y = Convert.ToDouble(Console.ReadLine());

            double result = last_result + y;

            Console.WriteLine();

            Console.WriteLine(" result : " + last_result + " + " + y + " = " + result);
            last_result = result;
        }

        static void subtraction()
        {
            Boolean toContinue = true;
            do
            {
                Console.Clear();
                menu(2);

                String choice;
                Console.Write(" choose : ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "a":
                    case "A":
                        subtraction_new();
                        Console.ReadKey();
                        break;

                    case "b":
                    case "B":
                        subtraction_last_result();
                        Console.ReadKey();
                        break;

                    case "c":
                    case "C":
                        toContinue = false;
                        break;
                }
            } while (toContinue);
        }

        static void subtraction_new()
        {
            double x, y;

            Console.WriteLine();

            Console.Write(" input x : ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write(" input y : ");
            y = Convert.ToDouble(Console.ReadLine());

            double result = x - y;

            Console.WriteLine();

            Console.WriteLine(" result : " + x + " - " + y + " = " + result);
            last_result = result;
        }

        static void subtraction_last_result()
        {
            double y;

            Console.WriteLine();

            Console.Write(" input x : " + last_result);

            Console.WriteLine();

            Console.Write(" input y : ");
            y = Convert.ToDouble(Console.ReadLine());

            double result = last_result - y;

            Console.WriteLine();

            Console.WriteLine(" result : " + last_result + " - " + y + " = " + result);
            last_result = result;
        }

        static void multiplication()
        {
            Boolean toContinue = true;
            do
            {
                Console.Clear();
                menu(3);

                String choice;
                Console.Write(" choose : ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "a":
                    case "A":
                        multiplication_new();
                        Console.ReadKey();
                        break;

                    case "b":
                    case "B":
                        multiplication_last_result();
                        Console.ReadKey();
                        break;

                    case "c":
                    case "C":
                        toContinue = false;
                        break;
                }
            } while (toContinue);
        }


        static void multiplication_new()
        {
            double x, y;

            Console.WriteLine();

            Console.Write(" input x : ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write(" input y : ");
            y = Convert.ToDouble(Console.ReadLine());

            double result = x * y;

            Console.WriteLine();

            Console.WriteLine(" result : " + x + " * " + y + " = " + result);
            last_result = result;
        }

        static void multiplication_last_result()
        {
            double y;

            Console.WriteLine();

            Console.Write(" input x : " + last_result);

            Console.WriteLine();

            Console.Write(" input y : ");
            y = Convert.ToDouble(Console.ReadLine());

            double result = last_result * y;

            Console.WriteLine();

            Console.WriteLine(" result : " + last_result + " * " + y + " = " + result);
            last_result = result;
        }

        static void division()
        {
            Boolean toContinue = true;
            do
            {
                Console.Clear();
                menu(4);

                String choice;
                Console.Write(" choose : ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "a":
                    case "A":
                        division_new();
                        Console.ReadKey();
                        break;

                    case "b":
                    case "B":
                        division_last_result();
                        Console.ReadKey();
                        break;

                    case "c":
                    case "C":
                        toContinue = false;
                        break;
                }
            } while (toContinue);
        }

        static void division_new()
        {
            double x, y;

            Console.WriteLine();

            Console.Write(" input x : ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write(" input y : ");
            y = Convert.ToDouble(Console.ReadLine());

            double result = x / y;

            Console.WriteLine();

            Console.WriteLine(" result : " + x + " / " + y + " = " + result);
            last_result = result;
        }

        static void division_last_result()
        {
            double y;

            Console.WriteLine();

            Console.Write(" input x : " + last_result);

            Console.WriteLine();

            Console.Write(" input y : ");
            y = Convert.ToDouble(Console.ReadLine());

            double result = last_result / y;

            Console.WriteLine();

            Console.WriteLine(" result : " + last_result + " / " + y + " = " + result);
            last_result = result;
        }

        static void power()
        {
            Boolean toContinue = true;
            do
            {
                Console.Clear();
                menu(5);

                String choice;
                Console.Write(" choose : ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "a":
                    case "A":
                        power_new();
                        Console.ReadKey();
                        break;

                    case "b":
                    case "B":
                        power_last_result();
                        Console.ReadKey();
                        break;

                    case "c":
                    case "C":
                        toContinue = false;
                        break;
                }
            } while (toContinue);
        }

        static void power_new()
        {
            double x, y;

            Console.WriteLine();

            Console.Write(" input x : ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write(" input y : ");
            y = Convert.ToDouble(Console.ReadLine());

            double result = Math.Pow(x,y);

            Console.WriteLine();

            Console.WriteLine(" result : " + x + " ^ " + y + " = " + result);
            last_result = result;
        }

        static void power_last_result()
        {
            double y;

            Console.WriteLine();

            Console.Write(" input x : " + last_result);

            Console.WriteLine();

            Console.Write(" input y : ");
            y = Convert.ToDouble(Console.ReadLine());

            double result = Math.Pow(last_result,y);

            Console.WriteLine();

            Console.WriteLine(" result : " + last_result + " ^ " + y + " = " + result);
            last_result = result;
        }

        static void square_root()
        {
            Boolean toContinue = true;
            do
            {
                Console.Clear();
                menu(6);

                String choice;
                Console.Write(" choose : ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "a":
                    case "A":
                        square_root_new();
                        Console.ReadKey();
                        break;

                    case "b":
                    case "B":
                        square_root_last_result();
                        Console.ReadKey();
                        break;

                    case "c":
                    case "C":
                        toContinue = false;
                        break;
                }
            } while (toContinue);
        }

        static void square_root_new()
        {
            double x;

            Console.WriteLine();

            Console.Write(" input x : ");
            x = Convert.ToDouble(Console.ReadLine());

            double result = Math.Sqrt(x);

            Console.WriteLine();

            Console.WriteLine(" result : " + x + " ^ 1/2 = " + result);
            last_result = result;
        }

        static void square_root_last_result()
        {
            Console.WriteLine();

            Console.Write(" input x : " + last_result);

            double result = Math.Sqrt(last_result);

            Console.WriteLine();

            Console.WriteLine(" result : " + last_result + " ^ 1/2 = " + result);
            last_result = result;
        }

        static void factorial()
        {
            Boolean toContinue = true;
            do
            {
                Console.Clear();
                menu(7);

                String choice;
                Console.Write(" choose : ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "a":
                    case "A":
                        factorial_new();
                        Console.ReadKey();
                        break;

                    case "b":
                    case "B":
                        sum_factorial();
                        Console.ReadKey();
                        break;

                    case "c":
                    case "C":
                        toContinue = false;
                        break;
                }
            } while (toContinue);
        }

        static double fac(double value)
        {
            if (value == 0)
                return 1;
            else
                return value * fac(value - 1); 
        }
        
        static void factorial_new()
        {
            double x;

            Console.WriteLine();

            Console.Write(" input x : ");
            x = Convert.ToDouble(Console.ReadLine());

            double result = fac(x);

            Console.WriteLine();

            Console.WriteLine(" result : " + x + "! = " + result);
            last_result = result;
        }

        static double sum_fac(double value)
        {
            if (value == 0)
                return 0;
            else
                return fac(value) + sum_fac(value - 1);
        }

        static void sum_factorial()
        {
            double n;

            Console.WriteLine();

            Console.Write(" input n : ");
            n = Convert.ToDouble(Console.ReadLine());

            double result = sum_fac(n);

            Console.WriteLine();

            Console.WriteLine(" result : " + result);
            last_result = result;
        }
    }
}
