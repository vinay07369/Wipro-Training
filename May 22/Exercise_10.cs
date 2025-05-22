class Program
{
    static void Main()
    {
       List<int> numbers = new List<int>() { 1,2,5,4,4,2,1,6,4,3};

        var duplicateNumbers = numbers.GroupBy(x => x)
                                      .Where(n => n.Count() > 1)
                                      .Select(x => x.Key)
                                      .ToList();

        Console.WriteLine("Duplicate Numbers in the List:");

        foreach (var number in duplicateNumbers)
        {
            Console.WriteLine(number);
        }                                
    }
}