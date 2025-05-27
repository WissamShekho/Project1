
List<int> Numbers = new List<int>() { 4, 1, 6, 3, 2, 9, 5, 7, 8, 0 };

Console.WriteLine("Even Numbers: ");
var evenNumbers = EvenNumbers(Numbers);

foreach (var n in evenNumbers)
{
    Console.Write(n + " ");
}
Console.WriteLine();


Console.WriteLine("Odd Numbers: ");
var oddNumbers = OddNumbers(Numbers);

foreach (var n in oddNumbers)
{
    Console.Write(n + " ");
}
Console.WriteLine();


static List<int> OddNumbers(List<int> numbers)
{
    List<int> Odds = new List<int>();

    if (numbers != null)
    {
        foreach (var num in numbers)
        {
            if (num % 2 == 1)
            {
                Odds.Add(num);
            }
            else
            {
                continue;
            }
        }
        return Odds;
    }
    else
    {
        return null!;
    }
}

static List<int> EvenNumbers(List<int> numbers)
{
    List<int> Evens = new List<int>();

    if (numbers != null)
    {
        foreach (var num in numbers)
        {
            if (num % 2 == 0)
            {
                Evens.Add(num);
            }
            else
            {
                continue;
            }
        }
        return Evens;
    }
    else
    {
        return null!;
    }
}

