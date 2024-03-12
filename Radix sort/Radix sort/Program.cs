namespace Radix_sort
{
    internal class Program
    {

        public static int getMax(int[] arr, int n)
        {
            int max = arr[0];
            for(int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static void countSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n];
            int i;
            int[] count = new int[10];

            // count arrayının hər bir dəyərinə 0 menimsedirik
            for(i = 0; i < 10; i++)
            {
                count[i] = 0;
            }
            //arr-ın uyğun olan(yəni exp = 1 olarsa təklik, exp = 10 olarsa 10luq)
            //mərtəbəsinin 10-a modunu alırıq və həmin indexi artırıq
            for(i = 0; i < n; i++) 
            {
                count[(arr[i] / exp) % 10]++;
            }


            //prefix sum alınır(məcmu cəmi) yəni hər bir indexdəki dəyər özündən öndəki ilə toplanır
            for (i = 1; i < 10; i++)
            {
                count[i] = count[i] + count[i - 1] ;
            }
            // output arrayın qurulması. 
            //intput arrayın i-ci elementinin mərtəbəsi çıxılsın bir( (arr[i] / exp) % 10] - 1 ) index
            //olaraq count arraydakı dəyəri çağırır həmin dəyər output arrayın indeksi olur və input arr-ın 
            // i-ci dəyəri mənimsədilir.
            //sonra count arrayın həmin dəyəri 1 vahid azaldılır.
            for (i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }
            // output arrayı arr - a mənimsədilir
            for (i = 0; i < n; i++)
                arr[i] = output[i];
        }

        public static void radixSort(int[] arr, int n)
        {

            //arr-in maksimum dəyəri tapılır
            int max = getMax(arr,n);


            //exp 1ci mərtəbədən başladılır(yəni təkliklərdən) maximum ədəd deyəkki 325 olarsa dövür
            // exp = 1000 olana qədər davam edəcək yəni 325/1000 = 0 olur və dövür bitir.
            for(int exp = 1; max/exp>0; exp*=10)
            {
                countSort(arr, n, exp);
            }
        }

        public static void print(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }

        public static void Main(string[] args)
        {
            int[] arr;
            
            Console.Write("massivin uzunlugunu daxil edin: ");
            int.TryParse(Console.ReadLine(),out int n);
            arr = new int[n];
            Console.WriteLine("Massivin edelerini daxil et:");
            for (int i = 0;i < n; i++)
            {
                Console.Write(i+" - ci elementi daxil et = ");
                arr[i]= int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n Input array:");
            print(arr, n);
            Console.WriteLine("\n\n Output array:");
            //funksiyalarin çağırılması
            radixSort(arr, n);
            print(arr, n);
        }
    }
}
