// https://leetcode.com/problems/valid-palindrome/description/?envType=study-plan-v2&envId=top-interview-150

        static bool IsPalindrome(string str)
        {
            str = str.ToLower();
            int start = 0;
            int end = str.Length - 1;
            while (start < end)
            {
                if (!char.IsLetterOrDigit(str[start]))
                {
                    start++;
                }
                else if (!char.IsLetterOrDigit(str[end]))
                {
                    end--;
                }
                else
                {
                    if (str[start] != str[end])
                    {
                        return false;
                    }
                    start++;
                    end--;
                }
            }
            return true;
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
