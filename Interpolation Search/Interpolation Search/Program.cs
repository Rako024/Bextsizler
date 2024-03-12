namespace Interpolation_Search
{
    internal class Program
    {
        public static int interpolationSearch(int[] arr,int low,int high, int target)
        {
            int pos;
            if(low< high && target >= arr[low] && target <= arr[high])
            {
                pos = low + ((target - arr[low]) * (high - low) / (arr[high] - arr[low]));
            

                if (arr[pos] == target)
                    return pos;

                if (arr[pos] < target)
                {
                    return interpolationSearch(arr, pos + 1, high, target);
                }
                if (arr[pos] > target)
                {
                    return interpolationSearch(arr, low , pos -1 , target);
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr;
            Console.Write("axtardiginiz ededi daxil edin: ");
            int.TryParse(Console.ReadLine(), out int target);

            Console.Write("massivin uzunlugunu daxil edin: ");
            int.TryParse(Console.ReadLine(), out int n);
            
            arr = new int[n];
            
            Console.WriteLine("Massivin edelerini daxil et:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(i + " - ci elementi daxil et = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            n--;
            int index = interpolationSearch(arr, 0, n, target);

            if(index != -1)
            {
                Console.WriteLine("Ededin indeksi : " + index);
            }
            else
            {
                Console.WriteLine("Eded tapilmadi");
            }
        }
    }
}
