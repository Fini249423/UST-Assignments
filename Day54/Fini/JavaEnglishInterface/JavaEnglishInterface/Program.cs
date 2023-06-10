using System;
public interface AdvancedArithmetic
{
    int divisor_sum(int n);
}
class MyCalculator : AdvancedArithmetic
{
    public int divisor_sum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        AdvancedArithmetic ar = new MyCalculator();
        int sum = ar.divisor_sum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic");
        Console.WriteLine(sum);
    }
}