using StackLibrary;

namespace ConsoleApp
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Stack stack = new Stack(new List<object>() { 2, 3, 5, 6, 2, 1, 5, 3, 9 });


            //var stack = new Stack();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            Console.WriteLine(stack.Pop());


            stack.Push('P');
            stack.Push('i');
            Console.WriteLine(stack.Count);

            stack.Clear();
            Console.WriteLine(stack.Count);















            //foreach (var item in stack3.Push('T'))
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}