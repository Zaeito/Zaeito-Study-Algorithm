using System;

public class Solution {
    public int[] solution(int[] arr, int k) {
        int[] answer = new int[arr.Length];
        if(k % 2 == 0)//k가 짝수일때
        {
            for(int i = 0; i < arr.Length; i++)
            {
                answer[i] = arr[i] + k;
            }
        }
        else//k가 홀수일때
        {
            for(int j = 0; j < arr.Length; j++)
            {
                answer[j] = arr[j] * k;
            }
        }
        return answer;
    }
}