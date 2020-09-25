using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWeekendHW
{
    class MyCalc
    {
        public int result;
        string answer;
        string choice;

        public int Plus(int a, int b)
        {
            result = a + b;
            Console.WriteLine($"{a} + {b} = 뭣이당가?");
            answer = Console.ReadLine().Trim().Replace(" ", "");

            if (answer.Equals(""))
            {
                throw new Exception();
            }
            else if (answer == result.ToString())
            {
                Console.WriteLine("정답입니다! 계속 하시겠습니까? \t 1.예 \t 2.아니오");
                choice = Console.ReadLine();

                if (answer.Equals(""))
                {
                    throw new Exception();
                }
                else if (choice == "1")
                {
                    return result;
                }
                else if (choice == "2")
                {
                    Console.WriteLine("프로그램을 종료합니다");
                    return 0;
                }
                else { throw new Exception(); }
            }
            
            return result;
        }

        public int Minus(int a, int b)
        {
            result = a - b;
            Console.WriteLine($"{a} - {b} = 뭣이당가?");
            answer = Console.ReadLine().Trim().Replace(" ", "");

            if (answer.Equals(""))
            {
                throw new Exception();
            }
            else if (answer == result.ToString())
            {
                Console.WriteLine("정답입니다! 계속 하시겠습니까? \t 1.예 \t 2.아니오");
                choice = Console.ReadLine();

                if (answer.Equals(""))
                {
                    throw new Exception();
                }
                else if (choice == "1")
                {

                }
            }

            return result;
        }

        public int Multiply(int a, int b)
        {
            result = a * b;
            Console.WriteLine($"{a} * {b} = 뭣이당가?");
            answer = Console.ReadLine().Trim().Replace(" ", "");

            if (answer.Equals(""))
            {
                throw new Exception();
            }
            else if (answer == result.ToString())
            {
                Console.WriteLine("정답입니다! 계속 하시겠습니까? \t 1.예 \t 2.아니오");
                choice = Console.ReadLine();

                if (answer.Equals(""))
                {
                    throw new Exception();
                }
                else if (choice == "1")
                {

                }
            }

            return result;
        }

        public int Divide(int a, int b)
        {
            result = a / b;
            Console.WriteLine($"{a} / {b} = 뭣이당가");
            answer = Console.ReadLine().Trim().Replace(" ", "");

            if (answer.Equals(""))
            {
                throw new Exception();
            }
            else if (answer == result.ToString())
            {
                Console.WriteLine("정답입니다! 계속 하시겠습니까? \t 1.예 \t 2.아니오");
                choice = Console.ReadLine();

                if (answer.Equals(""))
                {
                    throw new Exception();
                }
                else if (choice == "1")
                {

                }
            }

            return result;
        }
    }
}
