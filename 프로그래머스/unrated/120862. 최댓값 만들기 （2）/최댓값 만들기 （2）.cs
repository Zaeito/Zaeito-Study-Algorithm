using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int max = 0;
        for(int i=0;i<numbers.Length;i++)
        {
            for(int j=0;j<numbers.Length;j++)
            {
                if(i != j && numbers[i] * numbers[j] >= max)
                {
                    max = numbers[i] * numbers[j];
                }
            }
        }
        if(numbers.Length == 2)
        {
            max = numbers[0] * numbers[1];
        }
        answer = max;
        return answer;
    }
}