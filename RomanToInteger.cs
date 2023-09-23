//https://leetcode.com/problems/roman-to-integer/description/?envType=study-plan-v2&envId=top-interview-150
        static int RomanToInteger(string s)
        {
            int result = 0;
            int previousValue = 0;
            int currentValue = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                switch (s[i])
                {
                    case 'I':
                        currentValue = 1;
                        break;
                    case 'V':
                        currentValue = 5;
                        break;
                    case 'X':
                        currentValue = 10;
                        break;
                    case 'L':
                        currentValue = 50;
                        break;
                    case 'C':
                        currentValue = 100;
                        break;
                    case 'D':
                        currentValue = 500;
                        break;
                    case 'M':
                        currentValue = 1000;
                        break;
                }
                if (currentValue < previousValue)
                {
                    result -= currentValue;
                }
                else
                {
                    result += currentValue;
                }
                previousValue = currentValue;
            }
            return result;
        }
        // Time Complexity : O(n) where n is the length of the string "s"
        // Space Complexity : O(1)
