using System;

public class Solution
{
    public string solution(string my_string, int[,] queries)
    {
        char[] answer = my_string.ToCharArray();
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int first = queries[i, 0];
            int second = queries[i, 1] - queries[i, 0] + 1;
            Array.Reverse(answer, first, second);
        }
        return new string(answer);
    }
}