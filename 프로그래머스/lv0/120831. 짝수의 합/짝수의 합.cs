using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        if(n < 1)
        {
            answer = 0;
        }
        else
        {
            for(int i=2;i<=n;)
            {
                answer = answer + i;
                i = i + 2;
            }
        }
        return answer;
    }
}