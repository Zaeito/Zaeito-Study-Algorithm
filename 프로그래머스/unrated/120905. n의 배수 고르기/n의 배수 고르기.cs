using System;

public class Solution {
    public int[] solution(int n, int[] numlist) {
        int storage = 0;
        int index = 0;
        for(int i = 0; i < numlist.Length; i++)//배열 크기 알아내기
        {
            if(numlist[i] % n ==0)
            {
                storage += 1;
            }
        }
        int[] answer = new int[storage];
        for(int j = 0; j < numlist.Length; j++)//배열 크기 알아내기
        {
            if(numlist[j] % n ==0)
            {
                answer[index] = numlist[j];
                index += 1;
            }
        }
        return answer;
    }
}