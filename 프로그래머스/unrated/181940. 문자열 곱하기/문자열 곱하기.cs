using System;

public class Solution {
    public string solution(string my_string, int k) {
        string answer = "";
        string temp = "";
        temp = my_string;
        for(int i = 0;i < k;i++)
        {
            answer = String.Concat(answer,temp);
        }
        return answer;
    }
}