using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BingoBingo
{
    public class NumberFormatter
    {
        public string FormatNumbers(List<int> numbers)
        {
            var formattedNumbers = numbers.Select(n => n < 10 ? $"0{n}" : n.ToString()).ToList();
            var displayText = new StringBuilder();

            for (int i = 0; i < formattedNumbers.Count; i++)
            {
                displayText.Append(formattedNumbers[i] + " ");
                if ((i + 1) % 5 == 0) displayText.Append("\n");
            }

            return displayText.ToString();
        }
    }
}
