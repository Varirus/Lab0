namespace Lab0
{
    class FizzBuzz
    {
        int upperRange = 100;
        int num = 0;

        public FizzBuzz(int number)
        {
            if (number > upperRange)
                num = upperRange;
            else
                num = number;
        }
        public void show()
        {
            if (num % 3 == 0)
                Console.Write("Fizz");
            if (num % 5 == 0)
                Console.Write("Buzz");
            if (!(num % 3 == 0 || num % 5 == 0))
                Console.Write(num);
            Console.Write("\n");
        }
    }


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
