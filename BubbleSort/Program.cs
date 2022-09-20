namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 1, 2, 3, 4, 5, 6, 8, 7, 9, 10 };
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(1, 99);
            BubbleSort(array);
            printArray(array);
        }
        public static void BubbleSort(int[] sortingArray)
        {
            int i = 1, j, value;
            int arrayM = sortingArray.Length; //arrayM diziAdedi
            while(i < arrayM)
            {
                j = arrayM - 1;
                while(j >= 1)
                {
                    if (sortingArray[j-1] > sortingArray[j])
                    {
                        value = sortingArray[j];
                        sortingArray[j] = sortingArray[j-1];
                        sortingArray[j-1] = value;
                    }
                    j--;
                }
                i++;
            }
        }
        public static void printArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}