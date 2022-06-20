

Console.WriteLine(" prime number ");

int n = Convert.ToInt32(Console.ReadLine());
int i = 2, temp = 0;
while (i <= (n / 2))
{
    if (n % i == 0)
    {
        temp = 1;
        break;
    }
    i++;
}
if (temp == 1)
    Console.WriteLine(" it's a not prime number");
else
    Console.WriteLine(" it's a prime number");









