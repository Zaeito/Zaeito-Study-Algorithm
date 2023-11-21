using System;

public class Solution {
    public int[] solution(int n) {
        int storage = 0;
        int index = 0;
        for(int j = 1; j <= n; j++)
        {
            if(n % j ==0)
            {
                storage++;
            }
        }
        int[] answer = new int[storage];
        for(int i = 1; i <= n; i++)
        {
            if(n % i ==0)
            {
                answer[index] = i;
                index++;
            }
        }
        return answer;
    }
}