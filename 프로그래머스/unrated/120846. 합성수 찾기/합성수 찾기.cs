using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int temp = 0;
        int number = 0;//합성수의 수
        for(int i = 1; i <= n; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                if(i % j == 0)
                {
                    temp += 1;
                }
            }
            if(temp >= 3)//약수가 3개이상일 경우(합성수인 경우)
            {
                number += 1;
                temp = 0;
            }
            else
            {
                temp = 0;
            }
        }
        answer = number;
        return answer;
    }
}