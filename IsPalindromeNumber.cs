bool IsPalindrome(int number)
        {
            int temp = number;
            int reverse = 0;
            while(temp != 0)
            {
                reverse = reverse * 10 + temp % 10;
                temp = temp / 10;
            }
            return reverse == number;
        }
