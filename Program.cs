
namespace DataStructure
{
    class Program{
        static void Main(string[] args){
            Stack stack = new Stack([50,64,135,123,1,0]);
            while(!stack.IsEmpty()){
                System.Console.WriteLine(stack.Pop());
            }
        }
    }
}