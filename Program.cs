using System;

namespace Program
{
    class MyApplication
    {
        // Second Method();
        static void MyMethod()
        {
            int num_1, num_2, num_3;
            num_1 = 20;
            num_2 = 30;
            num_3 = 40;
            int total = num_3 + num_2 - num_1;
            Console.WriteLine($"The total is, {total }");
        }
        // Second Method();
        static void MySecondMethod()
        {
            //Get input from user;
            Console.Write("Enter any number ");
            double firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter any second number ");
            double secondNum = double.Parse(Console.ReadLine());

            //Select an operator to be executed on
            Console.WriteLine("1. '+', Addition. ");
            Console.WriteLine("2. '-', Subtraction. ");
            Console.WriteLine("3. '*', Multiplication. ");
            Console.WriteLine("4. '/', Division. ");
            Console.WriteLine("5. '%', Module. ");

            // A switch case that you choose your chpoi
            int choice = int.Parse(Console.ReadLine()); 
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{firstNum} + {secondNum} =  { firstNum + secondNum} ");
                    break;
                case 2:
                    Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum}");
                    break;
                case 3:
                    Console.WriteLine($"{firstNum} * {secondNum} = {firstNum * secondNum}");
                    break;
                case 4:
                    Console.WriteLine($"{firstNum} / {secondNum} = {firstNum / secondNum}");
                    break;
                case 5:
                    Console.WriteLine($"{firstNum} % {secondNum} = {firstNum % secondNum}");
                    break;
                default:
                    Console.WriteLine("Invadie inpute, please input a valid intiger ");
                    break;
            }
        }

        // Third Method()
        static void MyThirdMethod()
        {
            Console.Write("Enter your area ");
            double area = double.Parse(Console.ReadLine());
            const double pi = 3.14;
            double result = pi * area;
            Console.WriteLine("Area of a circle is = {0} ", result);
        }

        // Forth Method();
        // Write a program that can count the numbers of number that is divisble by 9, from 20-120;
       static void MyFourthMethod()
        {
            int count = 0;
            for(int i = 20; i < 120; i++)
            {
                if(i % 9 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("The numbers divisible by 9 is = {0} ", count);
        }
        static void MyFifthMethod(int age)
        {
            Console.WriteLine("I'm " + age + " Years old");
        }

        static void MySixtMethod(string fname, string sname, int age)
        {
            Console.WriteLine("My name is " + fname + sname + " I'm " + age + " years old");
        }

        static void My7ntMethod(string fname)
        {
            Console.WriteLine("My name is " + fname + " Ikpefua");
        }
        static int My8Method(int i, int y)
        {
            return i * y;
        }
        static double My9thMethod(double x)
        {
            return 12.5 % x;
        }
        static  double My10thMethod(double y)
        {
            return y / 5;
        }
        static double My11thMethod( double num)
        {
            return 12 % num;
        }




        static void Main(string[] args)
        {
            //MyMethod();
            //MySecondMethod();
            //MyThirdMethod();
            //MyFourthMethod();
            MyFifthMethod(30);
            MyFifthMethod(20);
            MyFifthMethod(28);
            MySixtMethod("Esther", " Ologbon", 21);
            MySixtMethod("Emmanuel", " Ikpefua", 28);
            MySixtMethod("Pamilerin", " Ikpefua", 1);
            MySixtMethod("Shindara", " Ologbon", 2);
            My7ntMethod("Tumininu");
            My7ntMethod("Tosin");
            My7ntMethod("Seamus");
            int ans = My8Method(5, 5);
            Console.WriteLine("The answer is = {0} ", ans);
            Console.WriteLine(My9thMethod(3));
            double z = My10thMethod(12.5);
            Console.WriteLine(z);
            Console.WriteLine(My10thMethod(z));
            double ans_2 = My11thMethod(5);
            Console.WriteLine(ans_2);

        }
    }
}
