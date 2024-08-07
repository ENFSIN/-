namespace lessons
{
   class Program
   { 
        static  int Indexof(int[] array, int value)
        { 
            for (int i = 0; i < array.Length; i++) 
            { 
                if (array[i] == value)
                { 
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] myarray = { 2, -5, 23, 55 };

            int result = Indexof(myarray, 23);
            
            Console.WriteLine(result);
        }
   }
}