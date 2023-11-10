using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int temp = 1;
        for(int i = 2; i <=11; i++)
        {
            for(int j=1; j <= i; j++)
            {
                temp = temp * j;
            }
            if(temp > n)
            {
                answer = i - 1;
                break;
            }
            temp = 1;
        }
        return answer;
    }
}