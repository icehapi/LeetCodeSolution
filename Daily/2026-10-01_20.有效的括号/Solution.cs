public class Solution
{
    private Dictionary<char, char> maps = new Dictionary<char, char>()
    {
        {')', '('},
        {']', '['},
        {'}', '{'}
    };
    public bool IsValid(string s)
    {
        var stk = new Stack<char>();

        foreach (var c in s)
        {
            if (maps.ContainsKey(c))
            {
                if (stk.Count == 0 || stk.Peek() != maps[c])
                {
                    return false;
                }
                stk.Pop();
            }
            else
            {
                stk.Push(c);
            }
        }

        return stk.Count == 0;
    }
}