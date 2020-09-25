using System;
using System.Collections.Generic;
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
            while (bFlag)
            {
                try
                {
                    Random rand = new Random();

                    int firstNumber = rand.Next(10, 100);
                    Console.WriteLine($"{firstNumber.ToString()}");
                    int secondNumber = rand.Next(10, 100);
                    Console.WriteLine($"{secondNumber.ToString()}");

                      
                    int function = rand.Next(1, 5);

                    switch (function)
                    {
                        case 1:

                            if (c1.Plus(firstNumber, secondNumber) == 0)
                                bFlag = false;
                            break;

                        case 2:

                            if (c1.Minus(firstNumber, secondNumber) == 0)
                                bFlag = false;
                            break;
                        case 3:

                            if(c1.Multiply(firstNumber, secondNumber)== 0)
                                bFlag = false;
                            break;
                        case 4:

                            if(c1.Divide(firstNumber, secondNumber) == 0)
                                bFlag = false;
                            break;

                    }
                    //

                }
                catch (Exception err)
                { 
                    Console.WriteLine(err.Message);
                }


            }
        }
    }
}
