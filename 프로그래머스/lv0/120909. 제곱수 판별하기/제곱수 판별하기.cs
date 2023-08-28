using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        for(int i = 1;;i++)
        {
            if(n == (i * i))
            {
                answer = 1;
                break;
            }
            
            else if(n < i * i)
            {
                answer = 2;
                break;
            }
        }
        return answer;
    }
}