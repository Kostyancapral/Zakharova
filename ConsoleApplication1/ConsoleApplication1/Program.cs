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
                Console.WriteLine("Выберите задание, рузультат которого вы хотите увидеть");
                Console.WriteLine("1 - Максимальное число");
                Console.WriteLine("2 - Кошка или собака");
                Console.WriteLine("3 - Пора года");
                Console.WriteLine("4 - Плохо или хорошо");
                Console.WriteLine("5 - День недели");
                Console.WriteLine("6 - Программа для такси");
                Console.WriteLine("7 - Проверка числа на простоту");
                Console.WriteLine("8 - Лоторея");
                Console.WriteLine("9 - Гривны, евро, доллары");
                Console.WriteLine("0 - Выход");
                s = Convert.ToInt32(Console.ReadLine());
                switch (s)
                {
                    case 1:
                        double a, b;
                        Console.WriteLine("Число 1  = ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Число 2  = ");
                        b = Convert.ToDouble(Console.ReadLine());
                        if (a < b)
                        {
                            Console.Write(" Максимальное число  = " + b);
                        }
                        else
                        {
                            Console.Write(" Максимальное число = " + a);
                        }
                        break;
                    case 2:
                        string c;
                        Console.Write("введите \"мяу\" или \"гав\" = ");
                        c = Console.ReadLine();
                        if (c == "мяу") Console.WriteLine("Покорми кота :)");
                        if (c == "гав") Console.WriteLine("Погуляй с собакой :ъ");
                        break;
                    case 3:
                        Console.Write("Введите порядковый номер месяца: ");
                        int d;
                        d = Convert.ToInt32(Console.ReadLine());
                        if (d == 1 || d == 2 || d == 12) Console.WriteLine("Зима");
                        else
                        {
                            if (d >= 3 && d <= 5) Console.WriteLine("Весна");
                            else
                            {
                                if (d >= 6 && d <= 8) Console.WriteLine("Лето");
                                else
                                {
                                    if (d >= 9 && d <= 11) Console.WriteLine("Осень");
                                    else
                                    {
                                        Console.WriteLine("На этой планете такого месяца нет :ъ");
                                    }
                                }
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("\"0\" или \"1\"");
                        int i;
                        i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(i == 0 ? "Плохо" : "Хорошо");
                        break;
                    case 5:
                        Console.WriteLine("Введите порядковый номер дня недели(от 1 до 7)");
                        int day;
                        day = Convert.ToInt32(Console.ReadLine());
                        switch (day)
                        {
                            case 1: Console.WriteLine("Понедельник"); break;
                            case 2: Console.WriteLine("Вторник"); break;
                            case 3: Console.WriteLine("Среда"); break;
                            case 4: Console.WriteLine("Четверг"); break;
                            case 5: Console.WriteLine("Пятница"); break;
                            case 6: Console.WriteLine("Суббота"); break;
                            case 7: Console.WriteLine("Воскресенье"); break; 
                        }
                        break;
                    case 6:
                        int km, min, summa = 0;
                        Console.Write("Километраж: ");
                        km = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Простой: ");
                        min = Convert.ToInt32(Console.ReadLine());
                        if (km >= 1 && km <= 5) summa = 20;
                        else
                        {
                            summa = ((km - 5) * 3) + 20;
                        }
                        Console.WriteLine("Summa proezda = " + (summa + min));
                        break;
                    case 7:
                        int number;
                        bool Prime = true;
                        Console.Write("Введите число: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        double stop = Math.Sqrt(number);
                        if (number % 2 == 0)
                        {
                            Prime = false;
                        }
                        else
                        {
                            for (int counter = 3; counter <= stop; counter += 2)
                            {
                                if (number % counter == 0)
                                {
                                    Prime = false;
                                    break;
                                }
                            }
                        }
                        string str;
                        Console.WriteLine(str = (Prime)? "Простое": "Не простое");
                        break;
                    case 8:
                        double deck;
                        int R = 0;
                        Random rand = new Random();
                        Console.Write("Ваша ставка: ");
                        deck = Convert.ToDouble(Console.ReadLine());
                        R = rand.Next(1, 13);
                        Console.WriteLine("" + R);
                        if (R >= 1 && R <= 5) Console.WriteLine("Вы проиграли:(");
                        if (R >= 6 && R <= 8) Console.WriteLine("Ваша ставка = " + deck);
                        if (R >= 9 && R <= 11) Console.WriteLine("Ваша ставка  = " + (deck * 2));
                        if (R > 11 && R < 13) Console.WriteLine("Ваша ставка" + (10 * deck));
                        break;
                    case 9:
                        int vi;
                        double S, s1, s2;
                        Console.Write("Введите сумму: ");
                        S = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("1 - гривны, 2 - доллар, 3 - евро");
                        vi = Convert.ToInt32(Console.ReadLine());
                        switch (vi)
                        {
                            case 1:
                                Console.WriteLine("Доллар " + Math.Round(s1 = S * 0.037, 2));
                                Console.WriteLine("Евро " + Math.Round(s2 = S * 0.034, 2));
                                break;
                            case 2:
                                Console.WriteLine("Гривна " + Math.Round(s1 = S / 0.037, 2));
                                Console.WriteLine("Евро " + Math.Round(s2 = S * 93, 2));
                                break;
                            case 3:
                                Console.WriteLine("Гривна " + Math.Round(s1 = S / 0.034, 2));
                                Console.WriteLine("Доллар " + Math.Round(s2 = S / 0.93, 2));
                                break;
                        }

                        break;
                }
                Console.WriteLine("Для продолжения нажмите Enter");
                Console.ReadLine();     
            }     
        }
    }
}
