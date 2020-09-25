using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWeekendHW
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bFlag = true;
            MyCalc c1 = new MyCalc();
            Random rand = new Random();
            while (bFlag)
            {
                try
                {
                    int firstNumber = rand.Next(10, 100);
                    Console.WriteLine($"{firstNumber.ToString()}");
                    int secondNumber = rand.Next(10, 100);
                    Console.WriteLine($"{secondNumber.ToString()}");


                    int function = rand.Next(1, 5);     //난수 연산자를 위해 생성

                    switch (function)
                    {
                        case 1:
                            if (c1.Plus(firstNumber, secondNumber) == -1)
                                bFlag = false;
                            break;

                        case 2:

                            if (c1.Minus(firstNumber, secondNumber) == 100000)
                                bFlag = false;
                            break;
                        case 3:

                            if (c1.Multiply(firstNumber, secondNumber) == -1)
                                bFlag = false;
                            break;
                        case 4:

                            if (c1.Divide(firstNumber, secondNumber) == -1)
                                bFlag = false;
                            break;

                    }
                }

                catch (NoNullAllowedException)
                {
                    Console.WriteLine("빈 값을 입력하셨습니다. 반드시 값을 입력해주세요.");
                }
                catch (Exception)
                {
                    Console.WriteLine("똑바로 하시는 게 없으니 처음부터 다시 하겠습니다.");
                }


            }
        }
    }
}
