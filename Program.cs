namespace Lab0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            FizzBuzz fb1 = new FizzBuzz(45);
            fb1.show();
            FizzBuzz fb2 = new FizzBuzz(20);
            fb2.show();
            FizzBuzz fb3 = new FizzBuzz(22);
            fb3.show();
            FizzBuzz fb4 = new FizzBuzz(21);
            fb4.show();
        }
    }
}
