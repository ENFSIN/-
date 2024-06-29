namespace Switch
{
    /// <summary>
    /// Switch.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Вызов програмы.
        /// </summary>
        /// <param name="args">Аргументы параметров.</param>
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите первое число");
                double firstValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число");
                double secondValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Выберите операцию:'+' '-' '*' '/' ");
                string action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;
                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;
                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;
                    case "/":
                        if (secondValue == 0)
                        {
                            Console.WriteLine("Произошла ошибка: делените на ноль.");
                        }
                        else
                        {
                            Console.WriteLine(firstValue / secondValue);
                        }

                        break;
                    default:
                        Console.WriteLine($"Операция {action} неизвестна");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}