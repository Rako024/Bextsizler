namespace MergeSort
{
    internal class Program
    {
            // Merge fonksiyonu, iki ayrılmış bölməni birləşdirir.
            static void Birlesdir(int[] arr, int l, int m, int r)
            {
                int n1 = m - l + 1;
                int n2 = r - m;

                int[] L = new int[n1];
                int[] R = new int[n2];

                for (int i = 0; i < n1; ++i)
                    L[i] = arr[l + i];
                for (int j = 0; j < n2; ++j)
                    R[j] = arr[m + 1 + j];

                int x = 0, y = 0;

                int z = l;
                while (x < n1 && y < n2)
                {
                    if (L[x] <= R[y])
                    {
                        arr[z] = L[x];
                        x++;
                    }
                    else
                    {
                        arr[z] = R[y];
                        y++;
                    }
                    z++;
                }

                while (x < n1)
                {
                    arr[z] = L[x];
                    x++;
                    z++;
                }

                while (y < n2)
                {
                    arr[z] = R[y];
                    y++;
                    z++;
                }
            }

            // Sort funksiyası, daxil edilmiş arrayi bölür və hər bir hissəni ayrı-ayrı sort edir.
            public static void Sort(int[] arr, int l, int r)
            {
                if (l < r)
                {
                    int m = l + (r - l) / 2;

                    Sort(arr, l, m);
                    Sort(arr, m + 1, r);

                    Birlesdir(arr, l, m, r);
                }
            }

            // Arrayi ekrana çap edən metod.
            public static void PrintArray(int[] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n; ++i)
                    Console.Write(arr[i] + " ");
                Console.WriteLine();
            }

            public static void Main(string[] args)
            {
                int[] arr = { 12, 11, 1, 5, 6, 7 };
                Console.WriteLine("Başlanğıc array:");
                PrintArray(arr);
                Sort(arr, 0, arr.Length - 1);
                Console.WriteLine("Sort olunmuş array:");
                PrintArray(arr);
            }
    }
}


