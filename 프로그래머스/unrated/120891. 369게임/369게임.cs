using System;

public class Solution {
    public int solution(int order) {
        int answer = 0;
        String temp = order.ToString();
        for(int i = 0; i < temp.Length; i++)
        {
            if(temp[i].ToString() == "3")
            {
                answer += 1;
            }
            else if(temp[i].ToString() == "6")
            {
                answer += 1;
            }
            else if(temp[i].ToString() == "9")
            {
                answer += 1;
            }
        }
        return answer;
    }
}