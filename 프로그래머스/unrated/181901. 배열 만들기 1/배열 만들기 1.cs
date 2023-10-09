using System;

public class Solution {
    public int[] solution(int n, int k) {
        int index = n / k;//배열의 길이
        int[] answer = new int[index];
        for(int i=0;i < index;i++)
        {
            answer[i] = k * (i + 1);
            
        }
        return answer;
    }
}