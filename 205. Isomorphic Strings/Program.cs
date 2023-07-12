Console.WriteLine(IsIsomorphic("blabla", "gbagba"));

bool IsIsomorphic(string s, string t) 
{
    var sDict = new Dictionary<char, char>();
    var tDict = new Dictionary<char, char>();
    for (int i = 0; i < s.Length; i++)
    {
        if (!sDict.ContainsKey(s[i]))
        {
            sDict.Add(s[i], t[i]);
        }
        if (!tDict.ContainsKey(t[i]))
        {
            tDict.Add(t[i], s[i]);
        }
        if (sDict[s[i]] != t[i] || tDict[t[i]] != s[i])
            return false;

    }
   
    return true;
}