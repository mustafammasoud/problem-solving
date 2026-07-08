namespace No._1;

class Program
{
    public static int SolveMeFirst(int number1 , int number2)=> number1 + number2;
    static void Main(string[] args)
    {
        Console.Write("Enter Value1 : ");
        int value1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Value2 : ");
        int value2 = Convert.ToInt32(Console.ReadLine());

        int result = SolveMeFirst(value1,value2);
        Console.WriteLine($"The Sum is : {result}");
    }
}
