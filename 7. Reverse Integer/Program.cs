// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine(Reverse(-123));
Console.WriteLine(Reverse(123));
int Reverse(int x)
{
    char[] characters = x.ToString().ToCharArray();
    char[] result = new char[characters.Length];
    int charsCount = characters.Length-1;
    for (int i = 0; i < characters.Length; i++)
    {
        result[i] = characters[charsCount];
        charsCount--;
    }

    for (int i = result.Length-2; i > 0; i--)
    {
            int j = result[i];
            result[i] = result[result.Length - i - 1];
            result[result.Length - i - 1] = (char)j;
    }
    if(result.Contains('-'))
    {
        result[result.Length - 1] = result[result.Length - 2];
        for (int i = result.Length-2; i > 0; i--)
        {
            
            result[i] = result[i - 1];
        }

        result[0] = '-';
    }
    return int.Parse(result);
}
