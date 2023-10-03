namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "0";
            int x = 0;
            while (a != "4")
            {
                Console.WriteLine("Выберите программу.");
                Console.WriteLine("1. Угадай число\n" + "2. Таблица умножения\n" + "3. Вывод делителей числа\n" + "4. Выйти из программы");
                a = Console.ReadLine();
                if (a == "1")
                {
                    Console.WriteLine("Угадайте число (от 0 до 100).");
                    Random rnd = new Random();
                    int z = rnd.Next(0, 100);
                    x = Convert.ToInt32(Console.ReadLine());
                    while (x != z)
                    {
                        if (x > z)
                        {
                            Console.WriteLine("Загаданное число меньше.");
                        }
                        else
                        {
                            Console.WriteLine("Загаданное число больше.");
                        }
                        x = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Угадали!");
                }
                if (a == "2")
                {
                    int[,] table = new int[10, 10];
                    for (int i = 1; i < 10; i++)
                    {  
                        for (int j = 1; j < 10; j++)
                        {
                            table[i, j] = i * j;
                         }
                    }
                    for (int i = 1; i < 10; i++)
                    {
                        for (int j = 1; j < 10; j++)
                        {
                            Console.Write(table[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
                if (a == "3")
                {
                    Console.WriteLine("Введите число: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= x; i++)
                    {
                        if (x % i == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }
    }
}
