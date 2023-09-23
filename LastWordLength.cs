// https://leetcode.com/problems/length-of-last-word/description/?envType=study-plan-v2&envId=top-interview-150
        int LastWordLengthApproach1(string s)
        {
            string[] parts = s.Split(' ');
            return parts[parts.Length - 1].Length;
        }

        int LastWordLengthApproach2(string s)
        {
            int length = 0;
            for(int i = s.Length - 1; i >=0; i--)
            {
                if(s[i] != ' ')
                {
                    length++;
                } 
                else if (length > 0)
                {
                    return length;
                }
            }
            return length;
        }
      // Time Complexity : O(n) where n is the length of the string "s"
    // Space Complexity : O(1)
