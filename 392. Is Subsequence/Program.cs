Console.WriteLine(IsSubsequence("b","abc"));//abc   plllabc

bool IsSubsequence(string s, string t)
{
    if (s == String.Empty) return true;
    if (t== String.Empty) return false;

    char[] sChar = s.ToCharArray();
    char[] tChar = t.ToCharArray();  
    int count = 0;
    bool answer = false;

    if (sChar.Length <= tChar.Length)
    {
        for (int i = 0; i < tChar.Length; i++)
        {
            if (sChar.Length == count)
            {
                answer = true;
                break;
            }

            if (sChar[count] == tChar[i]) count++;
        }
        answer = count == sChar.Length ? true : false;
        
    }

    else if(sChar.Length > tChar.Length)
    {
        for (int i = 0; i < sChar.Length; i++)
        {
            if (tChar.Length == count)
            {
                answer = true;
                break;
            }
            if (tChar[count] == sChar[i]) count++;
        }
        answer = count == tChar.Length ? true : false;
    }

    return answer;
}
