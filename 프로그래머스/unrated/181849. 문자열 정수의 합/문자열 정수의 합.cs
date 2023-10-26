using System;

public class Solution {
    public int solution(string num_str) {
        int answer = 0;
        string temp = "";
        for(int i=0; i < num_str.Length; i++)
        {
            temp = String.Concat(temp,num_str[i]);
            answer = answer + int.Parse(temp);
            temp = "";
        }
        return answer;
    }
}