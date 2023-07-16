Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
int LengthOfLongestSubstring(string s)
{
	var charSet = new HashSet<char>();
	int left = 0, right = 0, maxlength = 0;
	while(right < s.Length)
	{
		if (!charSet.Contains(s[right]))
		{
			charSet.Add(s[right]);
			right++;
			maxlength = Math.Max(maxlength, charSet.Count);
		}
		else
		{
			charSet.Remove(s[left]);
			left++;
		}
	}
	//Console.WriteLine(String.Join(",",charSet));
	return maxlength;
}