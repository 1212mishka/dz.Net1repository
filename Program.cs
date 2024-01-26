using System;
using System.Security.Principal;

internal class Program
{
    static void task1(int number)
    {
        if ( number <= 100 && number >= 1)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (number % 5 != 0 && number % 3 != 0) { Console.WriteLine(number); }
        }
        else
        {
            Console.WriteLine("Wrong diapason");
        }
    }
    static double task2(double num,double procent)
    {
        procent /= 100;
        return procent * num;
    }
    static string task3()
    {
        string str="";
        int number1 = 0;
        const int n = 4;
        Console.WriteLine("Input four numbers");
        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out number1);
            str += number1.ToString();
        }
        return str; 
    }
    static int task4(string number4,int change1,int change2)
    {
        if (number4.Length == 6)
        {
            Console.WriteLine("Input number1 for change");
            int.TryParse(Console.ReadLine(), out change1);
            Console.WriteLine("Input number2 for change");
            int.TryParse(Console.ReadLine(), out change2);
            char str1, str2;
            str1 = number4[change1 - 1];
            str2 = number4[change2 - 1];

            char[] digits = number4.ToString().ToCharArray();
            digits[change1 - 1] = str2;
            digits[change2 - 1] = str1;
            int number=0;
            int.TryParse(digits, out number);
            return number;
        }
        else
        {
            Console.WriteLine("Error");
            return 0;
        }
    }
    static void task5(string inputDate)
    {
        if (DateTime.TryParse(inputDate, out DateTime date))
        {
            int month = date.Month;
            string season;
            if (month >= 3 && month <= 5) { season = "Spring"; }
            else if (month >= 6 && month <= 8) { season = "Summer"; }
            else if (month >= 9 && month <= 11) { season = "Autmun"; }
            else { season = "Winter"; }
            string dayOfWeek = date.ToString("dddd");
            Console.WriteLine("Season: {0} day of week: {1}", season, dayOfWeek);
        }
    }
    static void task6(string str, double userinput , double temp)
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Choose Fahrenheit ,Celsius or Stop ");
            str = Console.ReadLine();

            if (str != "Stop")
            {
                Console.WriteLine("input temp");
                double.TryParse(Console.ReadLine(), out userinput);
            }

            switch (str)
            {
                case "Stop":
                    flag = false;
                    break;
                case "Fahrenheit":
                    temp = userinput * 1.8 + 32;
                    Console.WriteLine("Fahrenheit {0}", temp);
                    break;
                case "Celsius":
                    temp = (userinput - 32) * 0.55;
                    Console.WriteLine("Celsisus {0}", temp);
                    break;
                default:
                    Console.WriteLine("Wrong");
                    break;
            }
        }
    }
    static void task7(int num1,int num2)
    {
        int i, n;
        if (num1 > num2) { i = num2; n = num1; }
        else { i = num1; n = num2; }
        Console.WriteLine("Result:");
        for (; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    private static void Main(string[] args)
    {
        // 1
        Console.WriteLine("Task1");
        int number;
        Console.WriteLine("Input number");
        int.TryParse(Console.ReadLine(), out number);
        task1(number);
        // 2
        Console.WriteLine("Task2");
        double procent, num,result;
        Console.WriteLine("Input number");
        double.TryParse(Console.ReadLine(), out num);
        Console.WriteLine("Input procent");
        double.TryParse(Console.ReadLine(), out procent);
        result = task2(num, procent);
        Console.WriteLine(result);
        //3
        Console.WriteLine("Task3");
        string str = "";
        str=task3();
        Console.WriteLine(str);
        //4
        Console.WriteLine("Task4");
        string number4;
        int change1=0, change2=0,number1;
        Console.WriteLine("Input six digit number ");
        number4 = Console.ReadLine();
        number1=task4(number4,change1,change2);
        Console.WriteLine(number1);

        // 5
        Console.WriteLine("Task5");
        Console.WriteLine("Input date, day.month.year");
        string inputDate = Console.ReadLine();
        task5(inputDate);
        // //6
        Console.WriteLine("Task6");
        double userinput = 0, temp=0;
        string str1="";
        task6(str1,userinput,temp);
        //7
        Console.WriteLine("Task7");
        int num1, num2;
        Console.WriteLine("Input num1");
        int.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("Input num2");
        int.TryParse(Console.ReadLine(), out num2);
        task7(num1, num2);

    }
















}
