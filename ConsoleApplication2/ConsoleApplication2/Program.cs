using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int s = -1;
            while (s != 0)
            {
                Console.Clear();
                Console.WriteLine("Выберите задание");
                Console.WriteLine("1 - Таблица");
                Console.WriteLine("2 - Разряды");
                Console.WriteLine("3 - Больше или меньше");
                Console.WriteLine("4 - Квадраты чисел");
                Console.WriteLine("5 - Сренее арифметическое 1");
                Console.WriteLine("6 - Сренее арифметическое 2");
                Console.WriteLine("7 - Комбинации");
                Console.WriteLine("8 - Пароль");
                Console.WriteLine("0 - Выход");
                s = Convert.ToInt32(Console.ReadLine());
                switch (s)
                {
                    case 1:
                        int for_table;
                        Console.Write("Введите число: ");
                        for_table = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= 20; i++)
                        {
                            Console.WriteLine("*" + i + "    " + for_table * i);
                        }
                        break;
                    case 2:
                        int N, digits=0;
                        Console.Write("Введите число: ");
                        N = Convert.ToInt32(Console.ReadLine());
                        do
                        {
                            digits++;
                            N /= 10;
                        }
                        while (N != 0);
                        Console.WriteLine("Число разрядов: " + digits);
                        break;
                    case 3:
                        Random rnd = new Random();
                        int ch = 0, t;
                        t = rnd.Next(1, 147);
                        while (t != ch)
                        {
                            Console.Write("Введите число: ");
                            ch = Convert.ToInt32(Console.ReadLine());
                            if (t > ch)
                            {
                                Console.WriteLine("Больше");
                                Console.ReadLine();
                            }
                            else
                            {
                                if (t < ch)
                                {
                                    Console.WriteLine("Меньше");
                                    Console.ReadLine();
                                }
                            }
                        }
                        Console.WriteLine("В яблочко");
                        break;
                    case 4:
                        int Max;
                        Console.Write("Введите число: ");
                        Max = Convert.ToInt32(Console.ReadLine());
                        int cur = 0, for_pow = 1;
                        while (for_pow * for_pow < Max)
                        {
                            cur = for_pow * for_pow;
                            for_pow++;
                            Console.Write(cur+"    ");
                        }
                        break;
                    case 5:
                        int[] Arr=new int [5];
                        double sum=0;
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write("элемент["+Convert.ToString(i+1)+"] = ");
                            Arr[i] = Convert.ToInt32(Console.ReadLine());
                            sum += Arr[i];
                        }
                        sum /= 5;
                        Console.WriteLine("Среднее=" + sum);
                        break;
                    case 6:
                        Random rand = new Random();
                        int[] Mass = new int[5];
                        double Sum = 0;
                        for (int i = 0; i < 5; i++)
                        {
                            Mass[i] = rand.Next(-10000, 10000);
                            Console.WriteLine("элемент[" + (i + 1) + "] = " + Mass[i]);
                            Sum += Mass[i];
                        }
                        Sum /= 5;
                        Console.WriteLine("Среднее = " + Sum);
                        break;
                    case 7:
                        int A, B;
                        A = 0; B = 32;
                        while(B>=0)
                        {
                            Console.WriteLine("Кроликов = " + A + "    Гусей = " + B);
                            B -= 2;
                            A += 1;
                        }
                        break;
                    case 8:
                        string str="", p="root";
                        while (str != p)
                        {
                            Console.Clear();
                            Console.Write("Пароль: ");
                            str = Console.ReadLine();
                            if (str != p)
                            {
                                Console.WriteLine("Неверно");
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("Верно");
                        break;
                }
                Console.WriteLine("Для продолжения нажмите Enter");
                Console.ReadLine();     
            }     
        }
    }
}

