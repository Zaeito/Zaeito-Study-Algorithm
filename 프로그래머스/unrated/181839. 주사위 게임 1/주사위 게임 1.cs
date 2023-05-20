using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        if(a % 2 != 0 && b % 2 != 0)//둘 다 홀수
        {
            answer = a*a + b*b;
        }
        else if(a % 2 != 0 || b % 2 != 0)//둘 중 하나만 홀수
        {
            answer = 2 * (a + b);
        }
        else
        {
            if(a>b)
            {
                answer = a - b;
            }
            else
            {
                answer = b - a;
            }
        }
        return answer;
    }
}