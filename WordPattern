// https://leetcode.com/problems/word-pattern/description/?envType=study-plan-v2&envId=top-interview-150

bool WordPattern(string pattern, string s)
        {
            string[] words = s.Split(' ');
            if(pattern.Length != words.Length)
            {
                return false;
            }
            Dictionary<char, string> dict = new Dictionary<char, string>();
            for(int i = 0; i < pattern.Length; i++)
            {
                if(dict.ContainsKey(pattern[i]))
                {
                    if(dict[pattern[i]] != words[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if(dict.ContainsValue(words[i]))
                    {
                        return false;
                    }
                    dict.Add(pattern[i], words[i]);
                }
            }
            return true;
        }
        // Time Complexity : O(n) 
        // Space Complexity : O(1)
