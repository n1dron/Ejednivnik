using ejednevnik1;

namespace ejednevnik1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            spisok nowdela = new spisok();
            spisok nowdela1 = new spisok();
            spisok dela = new spisok();
            spisok olddela = new spisok();
            spisok olddela1 = new spisok();

            nowdela.Name = "Сходить на работу";
            nowdela.Menu = "Заработать деньги";
            nowdela.Now = new DateTime(2022, 10, 21);

            nowdela1.Name = "Съездить в колледж";
            nowdela1.Menu = "Научиться новому";
            nowdela1.Now = new DateTime(2022, 10, 21);

            dela.Name = "Приготовить вкусный ужин";
            dela.Menu = "Купить продукты";
            dela.Now = new DateTime(2022, 10, 22);

            olddela.Name = "Сделать практическую";
            olddela.Menu = "Посмотреть лекцию и задания в ней";
            olddela.Now = new DateTime(2022, 10, 20);

            olddela1.Name = "Провести выходные";
            olddela1.Menu = "Съездить к друзьям погулять";
            olddela1.Now = new DateTime(2022, 10, 19);

            Console.WriteLine("Список дел: чтобы посмотреть дела за некоторый промежуток используйте стрелки влево/вправо и нажмите Enter");
            Console.WriteLine("Нажмите на любую клавишу, чтобы запустить программу");
            DateTime now = new DateTime(2022, 10, 21);
            DateTime continue1 = new DateTime(2022, 10, 21);
            ConsoleKeyInfo clavisha = Console.ReadKey();
            int position = 1;
            while (clavisha.Key != ConsoleKey.Enter)
            {
                if (clavisha.Key == ConsoleKey.LeftArrow)
                {
                    now = now.AddDays(-1);

                }
                else if (clavisha.Key == ConsoleKey.RightArrow)
                {
                    now = now.AddDays(1);
                }
                else if (clavisha.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    if (position < 1)
                    {
                        position = 1;
                    }
                }
                else if (clavisha.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if (position > 1)
                    {
                        position = 2;
                    }
                }
                Console.Clear();
                Console.WriteLine("Выбрана дата" + " " + now);
                int x = 1;
                if (now == continue1)
                {
                    Console.WriteLine("    1. Сходить на работу ");
                    Console.WriteLine("    2. Съездить в колледж");
                    x = 1;
                }
                else if (now == continue1.AddDays(-1))
                {
                    Console.WriteLine("    1. Сделать практическую ");
                    x = 2;
                }
                else if (now == continue1.AddDays(-2))
                {
                    Console.WriteLine("    1. Провести выходные ");
                    x = 3;
                }
                else if (now == continue1.AddDays(1))
                {
                    Console.WriteLine("    1. Приготовить вкусный ужин ");
                    x = 4;
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("-->");
                clavisha = Console.ReadKey();
                Console.Clear();

                if (position == 1)
                {
                    if (x == 1)
                    {
                        Console.WriteLine(nowdela.Name);
                        Console.WriteLine(nowdela.Menu);
                        Console.WriteLine(nowdela.Now);
                    }
                    else if (x == 2)
                    {
                        Console.WriteLine(olddela.Name);
                        Console.WriteLine(olddela.Menu);
                        Console.WriteLine(olddela.Now);
                    }
                    else if (x == 3)
                    {
                        Console.WriteLine(olddela1.Name);
                        Console.WriteLine(olddela1.Menu);
                        Console.WriteLine(olddela1.Now);
                    }
                    else if (x == 4)
                    {
                        Console.WriteLine(dela.Name);
                        Console.WriteLine(dela.Menu);
                        Console.WriteLine(dela.Now);
                    }
                }
                if (position == 2)
                {
                    if (x == 1)
                    {
                        Console.WriteLine(nowdela1.Name);
                        Console.WriteLine(nowdela1.Menu);
                        Console.WriteLine(nowdela1.Now);
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}