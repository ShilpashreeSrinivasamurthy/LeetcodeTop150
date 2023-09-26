// https://leetcode.com/problems/happy-number/description/?envType=study-plan-v2&envId=top-interview-150

        bool IsHappy(int n)
        {
            HashSet<int> hashSet = new HashSet<int>();
            while (hashSet.Add(n))
            {
                int squareSum = 0;
                while(n > 0)
                {
                    int digit = n % 10;
                    squareSum += digit * digit;
                    n = n / 10;
                }
                if (squareSum == 1)
                {
                    return true;
                }
                n = squareSum;
            }
            return false;
        }
