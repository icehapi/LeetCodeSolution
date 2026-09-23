public class Solution
{
    public int MinOperations(int[] nums, int x)
    {
        int n = nums.Length;
        int sum = nums.Sum();
        if (sum < x)
            return -1;

        int r = 0;
        int leftSum = 0;
        int rightSum = sum;
        int ans = n + 1;

        for (int l = -1; l < n; l++)
        {
            if (l != -1)
                leftSum += nums[l];

            while (r < n && leftSum + rightSum > x)
            {
                rightSum -= nums[r];
                r++;
            }

            if (leftSum + rightSum == x)
                ans = Math.Min(ans, l + 1 + n - r);
        }

        return ans > n ? -1 : ans;
    }
}