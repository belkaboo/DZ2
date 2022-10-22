bool Weekend(int number)
{
    return number == 6 || number == 7;
}


Console.WriteLine("Input number of the  day: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (Weekend(dayNumber))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
