// https://leetcode.com/problems/factorial-trailing-zeroes/description/?envType=study-plan-v2&envId=top-interview-150

        int TrailingZeros(int n)
        {
            int result = 0;
            while(n != 0)
            {
                n = n / 5;
                result += n;
            }
            return result;
        }
