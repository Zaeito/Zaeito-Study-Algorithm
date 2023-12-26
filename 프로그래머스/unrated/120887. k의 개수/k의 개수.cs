using System;

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;
        int temp = i;
            
        for(int a = i; a <= j; a++)
        {
            temp = a;
            while(temp > 0)
            {
                if(temp % 10 == k)
                {
                    answer++;
                }
                temp /= 10;
            }
        }
        return answer;
    }
}