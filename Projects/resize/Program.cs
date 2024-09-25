namespace resize
{
    class programm
    {
        public static void Resize(ref int[] array, int newSize)
        {
            int[] newarray = new int[newSize];
            for (int i = 0; i < array.Length && i< newarray.Length; i++)
            {
                newarray[i] = array[i];
            }

            array = newarray;
        }

        public static void main(String[] args)
        {
            int[] mainarray = { 1, 2, 3, 4 };
            programm.Resize(ref mainarray, 10);
        }
    }
}
