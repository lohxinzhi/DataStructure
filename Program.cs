
namespace DataStructure
{
    class Program{
        static void Main(string[] args){
            DateTime now = DateTime.Now;
            var rnd = new Random();
            for (int i = 0; i<10; i++){
                System.Console.WriteLine($"Interation {i+1}");
                // int[] x = {5,7,1,3,12,17,0,8,10,2,4,6,-3,34,-33,53,65,0,4,144,4,20};
                int[] x = new int[100];
                for (int j = 0; j<x.Length; j++){
                    x[j] = rnd.Next(-1000,1000);
                }
                int[] y = new int[x.Length];
                x.CopyTo(y,0);
                now = DateTime.Now;
                Sorting.MergeSort(x);
                System.Console.WriteLine($"MergeSort: {(DateTime.Now-now).TotalMicroseconds} us" );
                foreach(var j in x){
                    System.Console.Write($"{j}, ");
                }
                System.Console.WriteLine();
                now = DateTime.Now;
                Sorting.QuickSort(y);
                System.Console.WriteLine($"QuickSort: {(DateTime.Now-now).TotalMicroseconds} us");
                foreach(var j in y){
                    System.Console.Write($"{j}, ");
                }
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
   

        }

    }
}