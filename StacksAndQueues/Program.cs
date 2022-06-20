// See https://aka.ms/new-console-template for more information
namespace StacksAndQueues
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            LinkedListStack value = new LinkedListStack();
            //value.push(70);
            // value.push(30);
            // value.push(56);
            //value.DisPlay();
            //value.Peek();
            //value.Pop();
            // value.IsEmpty();



            LinkedListQueues example = new LinkedListQueues();
            example.Enqueue(56);
            example.Enqueue(30);
            example.Enqueue(70);
            example.DisPlay();
            example.Dequeue();

        }
    }
}