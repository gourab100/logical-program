
 Console.WriteLine(" Reverse a number ");

int i = Convert.ToInt32(Console.ReadLine());
int revr = 0;
while (i != 0)
{
    revr = revr * 10 + i % 10;
    i = i / 10;

}
Console.WriteLine(" After reversing :" + revr);



