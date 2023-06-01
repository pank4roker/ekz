using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            //Console.Write("x=");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("y=");
            //int y = int.Parse(Console.ReadLine());
            //Console.Write($"{x}+{y}={x + y}");

            // 2
            //Console.Write("x=");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("y=");
            //int y = int.Parse(Console.ReadLine());
            //Console.Write("z=");
            //int z = int.Parse(Console.ReadLine());
            //Console.Write($"{x}+{y}+{z}={x + y+ z}");
            //3
            //Console.Write("x=");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("y=");
            //double y = double.Parse(Console.ReadLine());
            //Console.Write($"{x:f1}*{y:f1}={x * y:f1}");

            //4
            //Console.Write("x=");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("y=");
            //double y = double.Parse(Console.ReadLine());
            //Console.Write($"{x:f3}/{y:f3}={x / y:f3}");


            //5 
            //Console.Write("a=");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b=");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write($"{a}+{b}+={b}+{a}");
            //Console.ReadKey();
            //6
            //Console.Write("Как тeбя зовут?");
            //string name = Console.ReadLine();
            //Console.Write("Сколько тебе лет? ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("{0}, ты родился в {1} году. ", name, (2009 - age));

            // 7 
            //double count, nominal;
            //Console.Write("Номинал купюры = ");
            //nominal = double.Parse(Console.ReadLine());
            //Console.Write("Количество купюр = ");
            //count = double.Parse(Console.ReadLine());
            //double sum = count * nominal;
            //Console.WriteLine($"Сумма денег = {sum:f2} p.");
            //8 
            //Console.Write("a=");
            //int a = int.Parse(Console.ReadLine());
            //int P = a * 4;
            //Console.WriteLine(P);
            //9
            //Console.Write("a=");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b=");
            //int b = int.Parse(Console.ReadLine());
            //int P = 2 * (b + a);
            //Console.WriteLine(P);
            //10
            //const double pi = 3.14;
            //Console.Write("r=");
            //double r = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Длинна окружности={2 * pi * r}");
            //11
            //Console.Write("Введите объем=");
            //double volume = double.Parse(Console.ReadLine());
            //Console.WriteLine($"{(int)(volume * 1024 / 820)}");
            //12
            //Console.Write("Ввести дв число= ");
            //byte x = byte.Parse(Console.ReadLine());
            //Console.WriteLine($"d={x/10}\te={x%10}");
            //13
            //Console.Write("Введите число=");
            //int x = int.Parse(Console.ReadLine());
            //if(x>0)
            //{
            //    Console.WriteLine($"{x + 1}");
            //} 
            //    else
            //{
            //    Console.WriteLine($"{x - 2}");
            //}
            //14
            //Console.Write("Введите число=");
            //int x = int.Parse(Console.ReadLine());
            //if (x > 0)
            //        Console.WriteLine($"{x + 1}");
            //if(x<0)
            //            Console.WriteLine($"{x - 2}");
            //if (x == 0)
            //            Console.WriteLine($"{x = 10}");
            //15
            //Console.Write("Введите число=");
            //int x = int.Parse(Console.ReadLine());
            //if (x > 0)
            //    Console.WriteLine($"Положительное");
            //else if(x<0)
            //    Console.WriteLine($"Отрицательное");
            //else
            //    Console.WriteLine($"Равно 0");
            //16 
            //Console.Write("Bведите число а=");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Bведите число b=");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("Bведите число с=");
            //int с = int.Parse(Console.ReadLine());
            //if (a == b && b == с)
            //    Console.WriteLine("Треугольник равносторонний");
            //else
            //    Console.WriteLine("Nhteujkmybr неравносторонний");
            //17
            // Console.Write("ddедите число=");
            //int x = int.Parse(Console.ReadLine());
            //if (3 % x == 0)
            //    Console.WriteLine("число является делителем числа 3");
            //else
            //    Console.WriteLine("Не является делителем числа 3");
            //18
            //Random rnd = new Random();
            //for(int x = 1;x<=10;x++)
            //{
            //    int value = rnd.Next(-30, 30);
            //    if(value>0)
            //    {
            //        Console.WriteLine($"{value}-положительное");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{value}-отрицательное");
            //    }
            //}
            //19
            //Random rnd = new Random();
            //for (int x = 1; x <= 8; x++)
            //{
            //    int value = rnd.Next(-20, 330);
            //    if (value%2==0)
            //    {
            //        Console.WriteLine($"{value}-четное");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{value}-нечетное");
            //    }
            //}
            //20
            //Console.Write("Введите число а=");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Введите число b=");
            //int b = int.Parse(Console.ReadLine());
            //if (a > b)
            //    Console.WriteLine($"{a}>{b}");
            //else
            //    Console.WriteLine($"{b}>{a}");
            //21
            //Console.Write("Вв. день недели:");
            //byte day = byte.Parse(Console.ReadLine());
            //switch(day)
            //{
            //    case 1:Console.WriteLine("Понедельник");
            //        break;
            //    case 2:
            //        Console.WriteLine("вт");
            //        break;
            //    case 3:
            //        Console.WriteLine("ср");
            //        break;
            //    case 4:
            //        Console.WriteLine("чт");
            //        break;
            //    case 5:
            //        Console.WriteLine("пт");
            //        break;
            //    case 6:
            //        Console.WriteLine("сб");
            //        break;
            //    case 7:
            //        Console.WriteLine("вс");
            //        break;
            //    default:Console.WriteLine("Sos");
            //        break;
            //}
            //22 
            //for(int i=0;i<=99;i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine($"{i}");
            //}
            //Console.ReadKey();
            //23
            //for (int i = 0; i <= 99; i++)
            //{
            //    if (i % 2 == 1)
            //        Console.WriteLine($"{i}");
            //}
            //24
            //for (int i = 0; i <= 9; i++)
            //{

            //        Console.WriteLine("Ghbdtn");
            //}
            //25
            //Console.Write("Введите число: ");
            //int a = int.Parse(Console.ReadLine());
            //for (int i = 0; i < a; i++)
            //{
            //    Console.WriteLine("Ghbdtn");
            //}
            //26
            //for(int i=1;i<=5;i++)
            //{
            //    Console.WriteLine($"{i}"); 
            //}
            //27,29 
            //for(int i=0;i<=18;i++)
            //{
            //    Console.Write("#");
            //}
            //28
            //for(int i=10;i>=1;i--)
            //{
            //    Console.WriteLine(i);
            //}    
            //30
            //for (int x = 1; x <= 20;  x += 2)
            //{
            //    Console.WriteLine($"x={x}\ty={5 * x - 2}");
            //}
            //31
            //for (int i = 1; i <= 11; i+=2)
            //{
            //    if (i!= 3) 
            //        Console.Write($"{i}\t");    
            //}
            //32
            //for(int i=100;i<=200;i++)
            //{
            //    if (i % 3 == 0)
            //        console.writeline(i);
            //}    
            //33
            //for(int x=1;x<=30;x++)
            //{
            //    Console.WriteLine($"Кол-во:{x}\t Цена:{x * 20,4}");
            //}
            //34
            //int[] mass = new int[6];
            //for(int i=0;i<mass.Length;i++)
            //{
            //    Console.WriteLine($"mass[{i}]");
            //    mass[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for(int i=0;i<mass.Length;i++)
            //{
            //    Console.WriteLine($"mass[{i}]={mass[i]}");
            //}
            //35
            //int[] mass = new int[6];
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    Console.WriteLine($"mass[{i}]");
            //    mass[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = mass.Length-1; i >= 0; i--)
            //{
            //    Console.WriteLine($"mass[{i}]={mass[i]}");
            //}
            //36
            //double[] mass = new double[6];
            //for(int i=0;i<mass.Length;i++)
            //{
            //    Console.WriteLine($"mass[{i}]=");
            //}
            //mass
            //37
            //Random rnd = new Random();
            //double[] omas = new double[6];
            //for(int i=0;i<omas.Length;i++)
            //{
            //    omas[i] = -10+20*rnd.NextDouble();
            //}
            //foreach (double el in omas)
            //{
            //    Console.WriteLine($"{el}\t");
            //}
            //Console.WriteLine($"{omas[omas.Length - 1]}");
            //Console.ReadKey();
            //38,39
            //int[] omas = new int[]{3,4,-9,8,1,-6,2,-5,-1,7,5,9};
            //foreach(int el in omas)
            //{
            //    Console.WriteLine($"{el}\t");
            //}
            //40
            //int[] omas = new int[] { -37, 0, 50, 46, 34, 46, 4, 13 };
            //int count = 0;
            //for(int i=0;i<omas.Length;i++)
            //{
            //    if (omas[i]<0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("Кол-во" + count);
            //Console.ReadKey();
            //41
            //Random rnd = new Random();
            //int[] omas = new int[10];
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    omas[i] = rnd.Next(-100,100);
            //}
            //foreach (int el in omas)
            //{
            //    Console.WriteLine($"{el}\t");
            //}
            //Console.ReadKey();


        }
    }
}
