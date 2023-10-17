using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        int length = my_string.Length - 1;
        for(int i = length; i > -1; i--)
        {
            answer = String.Concat(answer,my_string[i]);
        }
        return answer;
    }
}