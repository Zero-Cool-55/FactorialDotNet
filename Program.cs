public class Function
{
    public static long Factorial(int n)
    {
        if(( n < 0 ) || ( n > 20))
        {
            return -1;
        }
        long temp = 1;
        for(var i = 1; i <= n; i++)
        {
            temp *= i;
        }
        return temp;
    }
}
class Test
{
    static int Main(string[] args)
    {
        if(args.Length == 0)
        {
            Console.WriteLine("Enter any numeric value");
            return 1;
        }
        int num;
        bool test = int.TryParse(args[0], out num);
        if (!test)
        {
            Console.WriteLine("Enter any numeric value");
            return 1;
        }
        long res = Function.Factorial(num);
        if (res == -1)
            Console.WriteLine("Value should be greater than 0 and less than 20");
        else
            Console.WriteLine($"The Factorial of {num} is {res}");
        return 0;
    }
}