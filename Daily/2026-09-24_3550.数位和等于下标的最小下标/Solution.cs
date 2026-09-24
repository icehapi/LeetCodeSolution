public class Solution
{
    public int SmallestIndex(int[] nums)
    {
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            if (i == calc(nums[i]))
                return i;
        }
        return -1;
    }

    private int calc(int num)
    {
        int res = 0;
        while (num > 0)
        {
            res += num % 10;
            num /= 10;
        }
        return res;
    }
}