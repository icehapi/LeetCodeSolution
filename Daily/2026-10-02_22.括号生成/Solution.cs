public class Solution
{
    private List<string> ans = new();
    public IList<string> GenerateParenthesis(int n)
    {
        dfs(n, n, "");
        return ans;
    }

    private void dfs(int left, int right, string cur)
    {
        if (left == 0 && right == 0)
        {
            ans.Add(cur);
            return;
        }
        if (left == right)
        {
            dfs(left - 1, right, cur + "(");
        }
        else
        {
            if (left > 0)
                dfs(left - 1, right, cur + "(");
            dfs(left, right - 1, cur + ")");
        }
    }
}