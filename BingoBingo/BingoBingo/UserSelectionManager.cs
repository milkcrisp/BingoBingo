using System.Collections.Generic;

namespace BingoBingo
{
    public class UserSelectionManager
    {
        private List<int> userNumbers = new List<int>();

        public void AddNumber(int number)
        {
            if (userNumbers.Count < 10 && !userNumbers.Contains(number))
            {
                userNumbers.Add(number);
            }
        }

        public void RemoveNumber(int number)
        {
            if (userNumbers.Contains(number))
            {
                userNumbers.Remove(number);
            }
        }

        public void ClearNumbers()
        {
            userNumbers.Clear();
        }

        public List<int> GetNumbers()
        {
            return new List<int>(userNumbers);
        }
    }
}
