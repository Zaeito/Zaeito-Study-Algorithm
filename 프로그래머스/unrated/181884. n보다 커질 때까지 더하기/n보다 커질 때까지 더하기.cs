using System;

public class Solution {
    public int solution(int[] numbers, int n) {
        int answer = 0;
        int temp = 0;
        for(int i=0;i<numbers.Length;i++)
        {
            temp += numbers[i];
            if(temp > n)
            {
                answer = temp;
                break;
            }
        }
        return answer;
    }
}