namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите а");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Выбор:");
                Console.WriteLine("1.Ввести а");
                Console.WriteLine("2.Ввести б");
                Console.WriteLine("3.выполнить операцию +");
                Console.WriteLine("4.выполнить операцию -");
                Console.WriteLine("5.выполнить операцию *");
                Console.WriteLine("6. выполнить операцию “/”");
           
                switch (Console.ReadLine())
                {
                    case "1":
                       
                        break;
                    case "2":
                        
                        break;
                    case "3":
                        Console.WriteLine($"Результат: {a} + {b} = " + (a + b));
                        break;
                    case "4":
                        
                        break;
                    case "5":
                        
                        break;
                    case "6":
                        
                        break;
                }
            }

        }
    }

}