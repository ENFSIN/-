namespace Консольноеприложение
{ /// <summary>
  /// Средне арифметическое.
  /// </summary>
   public class Program
   {
        /// <summary>
        /// Вызов прогамы.
        /// </summary>
        /// <param name="args">Аргументы параметров.</param>
       public static void Main(string[] args)
       {
            Console.WriteLine("введите число");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второй число; ");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = a + b;
            Console.WriteLine("среднее");
            double result = c / 2;
            Console.WriteLine(result);
       }
   }
}
