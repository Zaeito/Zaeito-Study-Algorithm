using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";
        int length = my_string.Length;
        for(int i = length - n; i < length; i++)
        {
            answer = String.Concat(answer,my_string[i]);
        }
        return answer;
    }
}