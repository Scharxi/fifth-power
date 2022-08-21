// Function that returns the first 100 odd numbers
IEnumerable<int> GetFirstHundredOddNumbers()
{
    return Enumerable.Range(1, 200).ToList().FindAll(a => a % 2 == 0).Take(100).ToList();
}

// Returns the sum of the first hundred odd numbers
long GetSumOfFirstHundredOddNumbers()
{
    return GetFirstHundredOddNumbers().Sum();
}

var fifthRoot = Math.Pow(Convert.ToDouble(GetSumOfFirstHundredOddNumbers()), 1.0 / 5);
Console.WriteLine(fifthRoot);