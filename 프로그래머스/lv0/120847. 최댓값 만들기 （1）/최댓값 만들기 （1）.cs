using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int temp = 0;
        for(int i=0;i<numbers.Length;i++)
        {
            for(int j=0;j<numbers.Length;j++)
            {
                if(i != j && numbers[i]*numbers[j] > temp)
                {
                    temp = numbers[i] * numbers[j];
                }
            }
        }
        answer = temp;
        return answer;
    }
}