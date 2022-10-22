Console.Clear();
Console.WriteLine("Input Number: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 100)
{
    Console.WriteLine("Third digit does't exist. Try again: ");
    Console.WriteLine("Input Number: ");
    number = Convert.ToInt32(Console.ReadLine());
}

int digitLength = number;
int digits = 0;

while (digitLength > 0)
{
    digitLength = digitLength / 10;
    digits++;
}

int[] array = new int[digits];

for (int i = 0; i < array.Length; i++)
{
    int lastValue = number % 10;
    array[i] = lastValue;
    number = number / 10;
}
int thirdDigit = array[digits-3];
Console.WriteLine($"Third digit = {thirdDigit}");


