namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SELECTION SORT ----------------------------

            int[] numbers = { 12, 32, 1, 34, 22, 75 };
            int kicikIndex;
            for (int i = 0; i < numbers.Length; i++)
            {
                kicikIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[kicikIndex] > numbers[j])
                    {
                        kicikIndex = j;
                    }
                }
                int temp = numbers[i];
                numbers[i] = numbers[kicikIndex];
                numbers[kicikIndex] = temp;

            }
            for (int k = 0; k < numbers.Length; k++)
            {
                Console.Write(numbers[k] + " ");
            }
        }
    }
}
