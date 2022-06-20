
Console.WriteLine("Perfect number");

int realnum = Convert.ToInt32(Console.ReadLine());
int rem, sum = 0, i;
for (i = 1; i <= realnum / 2; i++)
{
    rem = realnum % i;
    if (rem == 0)
    {
        sum += i;

    }
}
if (sum == realnum)
    Console.WriteLine("it's a perfect number");
else
    Console.WriteLine("it's a not perfect number");





