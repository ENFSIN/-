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
                double firstValue, secondValue;
                string action;
                Console.WriteLine("Введите первое число");
                firstValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число");
                secondValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Выберите операцию:'+' '-' '*' '/' ");
                action = Console.ReadLine();

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
                            Console.WriteLine(0);
                        }
                        else
                        {
                            Console.WriteLine(firstValue / secondValue);
                        }

                        break;
                    default:
                        Console.WriteLine("Не верное действие.");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}