// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/?envType=study-plan-v2&envId=top-interview-150

int IndexOfFirstOccurance(string haystack, string needle)
        {
            for (int i = 0; i < haystack.Length; i++)
            {
                if (i + needle.Length > haystack.Length)
                {
                    break;
                }
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }
                    if (j == needle.Length - 1)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        // Time Complexity :  O(m * n) where m = haystack length and n = needle length
        // Space Complexity : O(1)
