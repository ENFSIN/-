namespace While
{
    /// <summary>
    /// Цикл while.
    /// </summary>
   public class Program
    {
        /// <summary>
        /// Вызов програмы.
        /// </summary>
        /// <param name="args">Аргументы параметров.</param>
        public static void Main(string[] args)
        {
            uint oddNumbersCount = 0;
            uint evenNumbersCount = 0;
            int oddNumbersSum = 0;
            int evenNumbersSum = 0;
            Console.WriteLine("Введите первое число диапазона");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите последнее число диапазона");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersCount++;
                    evenNumbersSum += currentValue;
                }
                else
                {
                    oddNumbersCount++;
                    oddNumbersSum += currentValue;
                }
                currentValue++;
            }
            Console.WriteLine($"Количестиво нечетных чисел:{oddNumbersCount}");
            Console.WriteLine($"Колличество четных чисел:{evenNumbersCount}");
            Console.WriteLine($"Сумма нечетных чисел:{oddNumbersSum}");
            Console.WriteLine($"Сумма четных чисел:{evenNumbersSum}");
            Console.ReadLine();
        }
    }
}