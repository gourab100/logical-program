
Console.WriteLine(" Fibonacci Series ");



int n = Convert.ToInt32(Console.ReadLine());
int first = 0, second = 1, result, i;
Console.WriteLine("fibonacci series is:");
for (i = 0; i < n; i++)
{
    if (i <= 1)
        result = i;
    else
    {
        result = first + second;
        first = second;
        second = result;
    }
    Console.WriteLine(result);

}








