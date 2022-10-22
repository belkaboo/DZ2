// Task10

Console.Clear();
Console.WriteLine("Input three-digit number ");
int number = Convert.ToInt32(Console.ReadLine());
while (number < 100 | number > 999)
{
    Console.WriteLine("It's not a three-digit number. Try again!");
    Console.Write("Input three-digit number: ");
    number = Convert.ToInt32(Console.ReadLine());
}

int secondDigit = (number / 10) % 10;
Console.WriteLine($"Second digit = {secondDigit}");
