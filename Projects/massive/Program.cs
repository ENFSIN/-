namespace Lessons
{
    public class Programm
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите колличество элементов массива:\t");
            int elementsCount = int.Parse(Console.ReadLine());

            int[] array = new int[elementsCount];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите элемент массива под индексом {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Вывод массива: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}