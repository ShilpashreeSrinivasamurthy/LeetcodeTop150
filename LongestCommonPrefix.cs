// https://leetcode.com/problems/longest-common-prefix/description/?envType=study-plan-v2&envId=top-interview-150

static string LongestCommonPrefix(string[] strs)
        {
            Array.Sort(strs);
            int index = 0;
            string first = strs[0];
            string last = strs[strs.Length - 1];
            while(index < first.Length && index < last.Length)
            {
                if(first[index] == last[index])
                {
                    index++;
                }
                else
                {
                    break;
                }
            }
            return first.Substring(0, index);
        }
