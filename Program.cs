using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double numberOne;
                double numberTwo;
                string operation;
                double result;
                
                Console.WriteLine("Добро пожаловать в калькулятор!");

                try
                {
                    
                    Console.Write("Введите первое число(если это дробное число, то вводите через ','): ");
                    numberOne = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число(если это дробное число, то вводите через ','): ");
                    numberTwo = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Нормально пиши цифры!!!");
                    Console.ReadKey();
                    continue;
                }
                

                Console.Write("Введите арифметическое действие(+, -, *, /, %): ");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        result = numberOne + numberTwo;
                        Console.WriteLine(numberOne + " + " + numberTwo + " = " + result);
                        break;
                    case "-":
                        result = numberOne - numberTwo;
                        Console.WriteLine(numberOne + " - " + numberTwo + " = " + result);
                        break;
                    case "*":
                        result = numberOne * numberTwo;
                        Console.WriteLine(numberOne + " * " + numberTwo + " = " + result);
                        break;
                    case "/":
                        if (numberTwo == 0)
                        {
                            Console.WriteLine("На ноль делить нельзя, балбес!");
                        }
                        else
                        {
                            result = numberOne / numberTwo;
                            Console.WriteLine(numberOne + " / " + numberTwo + " = " + result);
                        }
                        break;
                    case "%":
                        result = numberOne % numberTwo;
                        Console.WriteLine(numberOne + " % " + numberTwo + " = " + result);
                        break;
                    default:
                        Console.WriteLine("Я не знаю такого знака(.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
