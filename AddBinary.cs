//https://leetcode.com/problems/add-binary/description/?envType=study-plan-v2&envId=top-interview-150

string AddBinary(string a, string b)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int i = a.Length - 1;
            int j = b.Length - 1;
            int sum = 0;
            while (i >=0 || j >= 0 || sum == 1)
            {
                if(i >= 0)
                {
                    sum += (int)a[i] - '0';
                    i--;
                }
                if (j >= 0)
                {
                    sum += (int)b[j] - '0';
                    j--;
                }
                stringBuilder.Append(sum % 2);
                sum = sum / 2;
            }
            return new string(stringBuilder.ToString().Reverse().ToArray());
        }

        // Time Complexity : O(max|a|, |b|) 
        // Space Complexity : O(max|a|, |b|)
