using System;
using System.Collections.Generic;
using System.Linq;

public class NumberGenerator
{
    private Random rand;

    public NumberGenerator()
    {
        rand = new Random();
    }

    public List<int> GenerateNumbers(int rangeStart, int rangeEnd, int count)
    {
        return Enumerable.Range(rangeStart, rangeEnd - rangeStart + 1).OrderBy(x => rand.Next()).Take(count).ToList();
    }

    public (int big, int small, int odd, int even) AnalyzeNumbers(List<int> numbers)
    {
        int big = numbers.Count(n => n > 40);
        int small = numbers.Count(n => n <= 40);
        int odd = numbers.Count(n => n % 2 != 0);
        int even = numbers.Count(n => n % 2 == 0);
        return (big, small, odd, even);
    }
}
