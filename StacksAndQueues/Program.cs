// See https://aka.ms/new-console-template for more information
namespace StacksAndQueues
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            LinkedListStack value = new LinkedListStack();
            value.push(70);
            value.push(30);
            value.push(56);
            value.DisPlay();
            value.Peek();
            value.Pop();
            value.IsEmpty();

        }
    }
}