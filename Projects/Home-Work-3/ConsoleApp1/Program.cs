namespace Консольноеприложение
{
    /// <summary>
    /// Нахождение суммы и произведения трех чисел.
    /// </summary>
   public class Program
   {
        /// <summary>
        /// Вызов програмы.
        /// </summary>
        /// <param name="args">Аргументы параметров.</param>
       public static void Main(string[] args)
       {
            Console.WriteLine("Введите число:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            double c = Convert.ToDouble(Console.ReadLine());
            double e = a + b + c;
            double d = a * b * c;
            Console.WriteLine($"Сумма={e}");
            Console.WriteLine($"Произведение={d}");
       }
    }
}