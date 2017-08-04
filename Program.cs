using System;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            CoinFlip();
            TossMultipleCoins(1000);
            Console.WriteLine(string.Join(",", Names()));
        }
        public static Random rand = new Random();
        public static int[] RandomArray(){
            int[] arr = new int[10];
            int sum = 0;
            int min = 0;
            int max = 0;
            for(int i = 0;i<10;i++){
                arr[i] = rand.Next(5,26);
            }
            for(int i = 0;i<arr.Length;i++){
                if(arr[i] > max){
                    max = arr[i];
                }
                if(arr[i] < min){
                    min = arr[i];
                }
                sum += arr[i];
            }
            Console.WriteLine("Min: "+min);
            Console.WriteLine("Max: "+max);
            Console.WriteLine("Sum: "+sum);
            return arr;
        }

        public static string CoinFlip(){
            string results = "";
            int val = rand.Next(0,100);

            if(val%2 == 0){
                results = "Heads";
            } else{
                results = "Tails";
            }
            return results;
        }

        public static double TossMultipleCoins(int num){
            double results = 0.0;
            double heads = 0;
            double tails = 0;

            for(int i = 0; i < num;i++){
                string win = CoinFlip();
                if(win == "Heads"){
                    heads++;
                } else {
                    tails++;
                }
            }
            results = heads/tails;
            Console.WriteLine("Heads: "+heads+" Tails: "+tails+" Ratio: "+results);
            return results;
        }

        public static string[] Names(){
            string[] names = {"Todd","Tiffany","Charlie","Geneva","Sydney"};

            for(int i=0;i<names.Length;i++){
                int h = rand.Next(names.Length);
                string temp = names[h];
            }
            return names;
        }
    }
}
