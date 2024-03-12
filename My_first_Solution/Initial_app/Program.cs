// See https://aka.ms/new-console-template for more information

int[] numbers = { 1, 2, 3, 4, 5 };
int max = numbers[0];
foreach (var i in numbers)
{
    if (i>max)
    {
        max = i;
    }   
}
Console.WriteLine(max);
