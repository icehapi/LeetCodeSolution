public class Solution
{
    public string Evaluate(string s, IList<IList<string>> knowledge)
    {
        var maps = new Dictionary<string, string>();
        foreach (var kd in knowledge)
        {
            maps.Add(kd[0], kd[1]);
        }

        var needReplace = false;
        var key = new StringBuilder();
        var res = new StringBuilder();
        foreach (var c in s)
        {
            if (c == '(')
            {
                needReplace = true;
            }
            else if (c == ')')
            {
                if (maps.ContainsKey(key.ToString()))
                {
                    res.Append(maps[key.ToString()]);
                }
                else
                {
                    res.Append('?');
                }
                needReplace = false;
                key.Length = 0;
            }
            else
            {
                if (needReplace)
                {
                    key.Append(c);
                }
                else
                {
                    res.Append(c);
                }
            }
        }
        return res.ToString();
    }
}