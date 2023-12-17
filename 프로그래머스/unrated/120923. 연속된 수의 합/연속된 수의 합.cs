using System;

public class Solution {
    public int[] solution(int num, int total) {
        int[] answer = new int[num];
        int temp = (total / num) - (total % num == 0 ? num / 2 : num / 2 - 1);
        
        for(int i = 0; i < num; i++)
        {
            answer[i] = temp;
            temp++;
        }
        return answer;
    }
}