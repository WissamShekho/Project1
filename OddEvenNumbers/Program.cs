
List<int> Numbers = new List<int>() { 4, 1, 6, 3, 2, 9, 5, 7, 8, 0 };


Console.WriteLine("Even Numbers: ");
List<int> evenNumbers = EvenNumbers(Numbers); //gets all even numbers in a list

printNumbers(evenNumbers); // printing result: 4, 6, 2, 8, 0  


Console.WriteLine("Odd Numbers: ");
List<int> oddNumbers = OddNumbers(Numbers); // gets all odd numbers in a list

PrintNumbers(oddNumbers); // printing result: 1, 3, 9, 5, 7


static void PrintNumbers(List<int> numbers)
{
    foreach (var n in numbers)
        Console.Write(n + " ");

    Console.WriteLine();
}

static List<int> OddNumbers(List<int> numbers)
{
    List<int> Odds = new List<int>();

    if (numbers != null)
    {
        foreach (var num in numbers)
            if (num % 2 == 1)
                Odds.Add(num);
       
        return Odds;
    }
    else
        return null!;
}

static List<int> EvenNumbers(List<int> numbers)
{
    List<int> Evens = new List<int>();

    if (numbers != null)
    {
        foreach (var num in numbers)
            if (num % 2 == 0)
                Evens.Add(num);

        return Evens;
    }
    else
        return null!;
}

