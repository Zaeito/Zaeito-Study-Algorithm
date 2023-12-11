using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int answer = 0;
        int temp = 1;
        
        for(int i = 0; i < k - 1; i++)
        {
            if(temp + 2 > numbers.Length)
            {
                temp = temp + 2;
                temp = temp - numbers.Length;
            }
            else
            {
                temp = temp + 2;
            }
        }
        answer = temp;
        return answer;
    }
}