// https://leetcode.com/problems/ransom-note/description/?envType=study-plan-v2&envId=top-interview-150
bool CanConstruct(string ransomNote, string magazine)
        {
            if(ransomNote == magazine)
            {
                return true;
            }
            if (ransomNote.Length > magazine.Length)
            {
                return false;
            }
            int[] counter = new int[26];
            foreach(char c in magazine.ToCharArray())
            {
                counter[c - 'a']++;
            }
            foreach(char c in ransomNote.ToCharArray())
            {
                if (counter[c - 'a'] == 0)
                {
                    return false;
                }
                counter[c - 'a']--;
            }
            return true;
        }

        // Time Complexity : O(n) 
        // Space Complexity : O(1)
