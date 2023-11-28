using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        String temp = n.ToString();
        for(int i = 0; i < temp.Length; i++)
        {
            answer = answer + int.Parse(temp[i].ToString());
        }
        return answer;
    }
}