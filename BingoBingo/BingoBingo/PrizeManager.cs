using System;
using System.Collections.Generic;

namespace BingoBingo
{
    public class PrizeManager
    {
        // 獎金數據
        public int SuperNoPrize { get; set; } = 1200; // 假設超級選號的獎金是1200元
        public int OddPrize { get; set; } = 150; // 猜單的獎金
        public int EvenPrize { get; set; } = 150; // 猜雙的獎金
        public int BigPrize { get; set; } = 150; // 猜大的獎金
        public int SmallPrize { get; set; } = 150; // 猜小的獎金

        // 獎金計算方法
        private readonly Dictionary<int, Dictionary<int, int>> prizeAmounts = new Dictionary<int, Dictionary<int, int>>();

        public PrizeManager()
        {
            // 初始化獎金數據
            AddPrizeData(10, new Dictionary<int, int>
            {
                { 10, 5000000 },
                {  9, 250000 },
                {  8, 25000 },
                {  7, 2500 },
                {  6, 250 },
                {  5, 25 },
                {  0, 25 }
            });

            AddPrizeData(9, new Dictionary<int, int>
            {
                { 9, 1000000 },
                { 8, 100000 },
                { 7, 3000 },
                { 6, 500 },
                { 5, 100 },
                { 4, 25 },
                { 0, 25 }
            });

            AddPrizeData(8, new Dictionary<int, int>
            {
                { 8, 500000 },
                { 7, 20000 },
                { 6, 1000 },
                { 5, 200 },
                { 4, 25 },
                { 0, 25 }
            });

            AddPrizeData(7, new Dictionary<int, int>
            {
                { 7, 80000 },
                { 6, 3000 },
                { 5, 300 },
                { 4, 50 },
                { 3, 25 },
                { 0, 25 }
            });

            AddPrizeData(6, new Dictionary<int, int>
            {
                { 6, 25000 },
                { 5, 1000 },
                { 4, 200 },
                { 3, 25 },
                { 0, 25 }
            });

            AddPrizeData(5, new Dictionary<int, int>
            {
                { 5, 7500 },
                { 4, 500 },
                { 3, 50 },
            });

            AddPrizeData(4, new Dictionary<int, int>
            {
                { 4, 1000 },
                { 3, 100 },
                { 2, 25 },
            });

            AddPrizeData(3, new Dictionary<int, int>
            {
                { 3, 500 },
                { 2, 50 },
            });

            AddPrizeData(2, new Dictionary<int, int>
            {
                { 2, 75 },
                { 1, 25 },
            });

            AddPrizeData(1, new Dictionary<int, int>
            {
                { 1, 50 },
            });
        }

        private void AddPrizeData(int stars, Dictionary<int, int> prizes)
        {
            // 檢查字典中是否已經包含這個星數
            if (!prizeAmounts.ContainsKey(stars))
            {
                prizeAmounts[stars] = prizes;
            }
            else
            {
                // 處理已經存在的情況，根據需要可以更新獎金數據
                // prizeAmounts[stars] = prizes; // 如果需要更新現有數據
            }
        }

        public int CalculatePrize(int stars, int matchedNumbers, bool hasSuperNumber, bool isOddEvenSelected, bool isBigSmallSelected, bool hasSuperNumberHit, bool isBigSmallMatch, bool isOddEvenMatch)
        {
            int prize = 0;

            // 根據玩法選擇計算獎金
            if (stars >= 1 && stars <= 10)
            {
                // 根據選擇的星數計算獎金
                prize = GetPrizeByStars(stars, matchedNumbers);
            }

            // 超級選號的獎金計算
            if (hasSuperNumber && hasSuperNumberHit)
            {
                prize += SuperNoPrize;
            }

            // 猜單雙的獎金計算
            if (isOddEvenSelected && isOddEvenMatch)
            {
                prize += OddPrize;
            }

            // 猜大小的獎金計算
            if (isBigSmallSelected && isBigSmallMatch)
            {
                prize += BigPrize;
            }

            return prize;
        }

        private int GetPrizeByStars(int stars, int matchedNumbers)
        {
            // 根據選擇的星數和中獎數字計算獎金
            if (prizeAmounts.ContainsKey(stars) && prizeAmounts[stars].ContainsKey(matchedNumbers))
            {
                return prizeAmounts[stars][matchedNumbers];
            }
            return 0;
        }
    }
}
