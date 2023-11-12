namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello everyone!");
            Console.WriteLine(GreetBlack);
            Console.WriteLine(GreetWhite);
        }
        static void GreetWhite()
        {
            Console.WriteLine("hello, white!");
        }

        static void GreetBlack()
        {
            Console.WriteLine("hello, black!");
        }
    }
}