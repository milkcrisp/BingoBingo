using System;
using System.Collections.Generic;

public class UserInputParser
{
    public List<int> ParseUserInput(string input)
    {
        string[] parts = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        List<int> numbers = new List<int>();

        foreach (string part in parts)
        {
            if (int.TryParse(part, out int number))
            {
                if (number >= 1 && number <= 80 && !numbers.Contains(number))
                {
                    numbers.Add(number);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        if (numbers.Count >= 1 && numbers.Count <= 10)
        {
            return numbers;
        }

        return null;
    }
}