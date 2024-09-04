
namespace DataStructure
{
    class Program{
        static void Main(string[] args){
            List<int> list = new List<int>{60,2,3,4,4,7,3,7,0,3,5,6,7,8,0};
            MaxHeap x = new MaxHeap(list);
            System.Console.WriteLine(x.Peek());

            int[] y = {23,5,76,8,0};

            foreach(int i in y){
                x.Insert(i);
            }

            while(x.Count>0){
                System.Console.WriteLine(x.Pop());
            }
        }
    }
}