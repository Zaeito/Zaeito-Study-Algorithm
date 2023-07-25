using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        String temp1 = "" + a + b;
        String temp2 = "" + b + a;
        if(int.Parse(temp1) >= int.Parse(temp2))
        {
            answer =  int.Parse(temp1);
        }
        else
        {
            answer =  int.Parse(temp2);
        }
        return answer;
    }
}