using System;
using System.Collections.Generic;
using System.Data;
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
        bool bFlag = true;
        bool cFlag = true;


        public int Plus(int a, int b)
        {
            while (cFlag)
            {
                result = a + b;
                Console.WriteLine($"{a} + {b} = 뭘까요?");
                answer = Console.ReadLine().Trim().Replace(" ", "");

                if (answer.Equals(""))
                {
                    throw new NoNullAllowedException();
                }
                else if (answer == result.ToString())
                {
                    Console.WriteLine("정답입니다!");
                    while (bFlag)
                    {
                        Console.WriteLine("계속 하시겠습니까?");
                        bFlag = true;

                        Console.WriteLine("1.예 \t 2.아니오 \t 숫자로 입력해주세요");
                        choice = Console.ReadLine().Trim().Replace(" ", "");

                        if (!choice.Equals(""))
                        {
                            bFlag = false;
                        }
                        else
                        { Console.WriteLine("다시 입력하세요"); }

                    }

                    if (choice == "1")
                    {

                        return result;
                    }
                    else if (choice == "2")
                    {

                        Console.WriteLine("프로그램을 종료합니다");

                        return -1;
                    }
                    else
                    {
                        throw new Exception();

                    }

                }
                else
                {
                    Console.WriteLine("오답입니다. 사칙연산에 약하시네요.");
                    //while (bFlag)
                    //{


                    //    //Console.WriteLine("계속 하시겠습니까?");
                    //    //bFlag = true;

                    //    //Console.WriteLine("1.예 \t 2.아니오 \t 숫자로 입력해주세요");
                    //    //choice = Console.ReadLine().Trim().Replace(" ", "");

                    //    //if (choice.Equals(""))
                    //    //{
                    //    //    Console.WriteLine("다시 입력하세요");
                    //    //}
                    //    //else if (choice == "1")
                    //    //{
                    //    //    return result;
                    //    //}
                    //    //else if (choice == "2")
                    //    //{

                    //    //    Console.WriteLine("프로그램을 종료합니다");

                    //    //    return -1;
                    //    //}
                    //    //else
                    //    //{
                    //    //    throw new Exception();

                    //    //}

                    //}
                }
            }

            return result;
        }

        public int Minus(int a, int b)
        {
            while (cFlag)
            {
                result = a - b;
                Console.WriteLine($"{a} - {b} = 뭘까요?");
                answer = Console.ReadLine().Trim().Replace(" ", "");

                if (answer.Equals(""))
                {
                    throw new NoNullAllowedException();
                }
                else if (answer == result.ToString())
                {
                    Console.WriteLine("정답입니다!");
                    while (bFlag)
                    {
                        Console.WriteLine("계속 하시겠습니까?");
                        bFlag = true;

                        Console.WriteLine("1.예 \t 2.아니오 \t 숫자로 입력해주세요");
                        choice = Console.ReadLine().Trim().Replace(" ", "");

                        if (!choice.Equals(""))
                        {
                            bFlag = false;
                        }
                        else
                        { Console.WriteLine("다시 입력하세요"); }

                    }

                    if (choice == "1")
                    {

                        return result;
                    }
                    else if (choice == "2")
                    {

                        Console.WriteLine("프로그램을 종료합니다");

                        return 100000;
                    }
                    else
                    {
                        throw new Exception();

                    }

                }
                else
                {
                    Console.WriteLine("오답입니다. 사칙연산에 약하시네요.");
                    //while (bFlag)
                    //{
                    //    Console.WriteLine("계속 하시겠습니까?");
                    //    bFlag = true;

                    //    Console.WriteLine("1.예 \t 2.아니오 \t 숫자로 입력해주세요");
                    //    choice = Console.ReadLine().Trim().Replace(" ", "");

                    //    if (choice.Equals(""))
                    //    {
                    //        Console.WriteLine("다시 입력하세요");
                    //    }
                    //    else if (choice == "1")
                    //    {
                    //        return result;
                    //    }
                    //    else if (choice == "2")
                    //    {

                    //        Console.WriteLine("프로그램을 종료합니다");

                    //        return 100000;
                    //    }
                    //    else
                    //    {
                    //        throw new Exception();

                    //    }

                    //}
                }
            }

            return result;
        }

        public int Multiply(int a, int b)
        {
            while (cFlag)
            {
                result = a * b;
                Console.WriteLine($"{a} * {b} = 뭘까요?");
                answer = Console.ReadLine().Trim().Replace(" ", "");

                if (answer.Equals(""))
                {
                    throw new NoNullAllowedException();
                }
                else if (answer == result.ToString())
                {
                    Console.WriteLine("정답입니다!");
                    while (bFlag)
                    {
                        Console.WriteLine("계속 하시겠습니까?");
                        bFlag = true;

                        Console.WriteLine("1.예 \t 2.아니오 \t 숫자로 입력해주세요");
                        choice = Console.ReadLine().Trim().Replace(" ", "");

                        if (!choice.Equals(""))
                        {
                            bFlag = false;
                        }
                        else
                        { Console.WriteLine("다시 입력하세요"); }

                    }

                    if (choice == "1")
                    {

                        return result;
                    }
                    else if (choice == "2")
                    {

                        Console.WriteLine("프로그램을 종료합니다");

                        return -1;
                    }
                    else
                    {
                        throw new Exception();

                    }

                }
                else
                {
                    Console.WriteLine("오답입니다. 사칙연산에 약하시네요.");
                    //while (bFlag)
                    //{
                    //    Console.WriteLine("계속 하시겠습니까?");
                    //    bFlag = true;

                    //    Console.WriteLine("1.예 \t 2.아니오 \t 숫자로 입력해주세요");
                    //    choice = Console.ReadLine().Trim().Replace(" ", "");

                    //    if (choice.Equals(""))
                    //    {
                    //        Console.WriteLine("다시 입력하세요");
                    //    }
                    //    else if (choice == "1")
                    //    {
                    //        return result;
                    //    }
                    //    else if (choice == "2")
                    //    {

                    //        Console.WriteLine("프로그램을 종료합니다");

                    //        return -1;
                    //    }
                    //    else
                    //    {
                    //        throw new Exception();

                    //    }

                    //}
                }
            }

            return result;
        }

        public int Divide(int a, int b)
        {
            while (cFlag)
            {
                result = a / b;
                Console.WriteLine($"{a} / {b} = 뭘까요?");
                answer = Console.ReadLine().Trim().Replace(" ", "");

                if (answer.Equals(""))
                {
                    throw new NoNullAllowedException();
                }
                else if (answer == result.ToString())
                {
                    Console.WriteLine("정답입니다!");
                    while (bFlag)
                    {
                        Console.WriteLine("계속 하시겠습니까?");
                        bFlag = true;

                        Console.WriteLine("1.예 \t 2.아니오 \t 숫자로 입력해주세요");
                        choice = Console.ReadLine().Trim().Replace(" ", "");

                        if (!choice.Equals(""))
                        {
                            bFlag = false;
                        }
                        else
                        { Console.WriteLine("다시 입력하세요"); }

                    }
                    //비프래그는 현재 폴스
                    if (choice == "1")
                    {

                        return result;
                    }
                    else if (choice == "2")
                    {

                        Console.WriteLine("프로그램을 종료합니다");

                        return -1;
                    }
                    else
                    {
                        throw new Exception();

                    }

                }
                else
                {
                    //Console.WriteLine("오답입니다. 사칙연산에 약하시네요.");
                    //while (bFlag)
                    //{
                    //    Console.WriteLine("계속 하시겠습니까?");
                    //    bFlag = true;

                    //    Console.WriteLine("1.예 \t 2.아니오 \t 숫자로 입력해주세요");
                    //    choice = Console.ReadLine().Trim().Replace(" ", "");

                    //    if (choice.Equals(""))
                    //    {
                    //        Console.WriteLine("다시 입력하세요");
                    //    }
                    //    else if (choice == "1")
                    //    {
                    //        return result;
                    //    }
                    //    else if (choice == "2")
                    //    {

                    //        Console.WriteLine("프로그램을 종료합니다");

                    //        return -1;
                    //    }
                    //    else
                    //    {
                    //        throw new Exception();

                    //    }

                    //}
                }
            }

            return result;
        }
    }
}
