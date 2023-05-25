using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        if(n % 2 == 0)//짝수
        {
            for(int j=2;j<=n;)
            {
                answer = answer + (j*j);
                j = j + 2;
            }
        }
        else//홀수
        {
            for(int i =1;i<=n;)
            {
                answer = answer + i;
                i = i + 2;
            }
        }
        return answer;
    }
}