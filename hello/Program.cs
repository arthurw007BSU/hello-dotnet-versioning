namespace hello;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        var number = int.Parse(Console.ReadLine());

        Console.WriteLine("this is your number: "+number );

    }
}
