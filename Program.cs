internal class Program
{
    private static void Main(string[] args)
    {
        Calculation();
    }
        static void Calculation()
        {
        Console.Clear();
        Console.WriteLine("--------------------");
        Console.WriteLine("Multiples of 3 or 5");;
        Console.WriteLine("--------------------");
        Console.WriteLine("");
        Console.WriteLine("Enter a number:");
        int sum=0;
        int a = Convert.ToInt32(Console.ReadLine());
        int value = (a - 1);
        if (value <= 2)
            Console.WriteLine(0);
        else
        do{ 
            if (value % 3 == 0 || value % 5 == 0)
            {
                sum += value; 
            }
            value--;
        } while (value >= 3);
        Console.WriteLine("Result:" + sum);
        }
}
