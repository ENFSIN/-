namespace ConsoleApp1
{
    /// <summary>
    /// Проверка числа на четность.
    /// </summary>
   public class Program
    {
        /// <summary>
        /// Вызов програмы.
        /// </summary>
        /// <param name="args">Аргументы параметров.</param>
       public static void Main(string[] args)
       {
            int a;
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Число четное.");
            }
            else
            {
                Console.WriteLine("Число не четное.");
            }
       }
   }
}