using System;

public class Solution {
    public int[] solution(int start, int end_num) {
        int length = start - end_num + 1;
        int index = 0;
        int[] answer = new int[length];
        for(int i = start; i >= end_num; i--)
        {
            answer[index] = i;
            index++;
        }
        return answer;
    }
}