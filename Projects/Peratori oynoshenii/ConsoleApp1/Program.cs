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
           string classify;
           int a = int.Parse(Console.ReadLine());
           classify = (a % 2 == 0) ? "Число четное." : "Число не четное.";
           Console.WriteLine(classify);
       }
   }
}