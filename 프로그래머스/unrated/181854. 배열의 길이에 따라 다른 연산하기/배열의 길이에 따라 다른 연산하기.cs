using System;

public class Solution {
    public int[] solution(int[] arr, int n) {
        int[] answer = new int[arr.Length];
        if(arr.Length % 2 ==0)//arr의 배열의 길이가 짝수일때
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(i % 2 != 0)
                {
                    answer[i] = arr[i] + n;
                }
                else
                {
                    answer[i] = arr[i];
                }
            }
        }
        else//arr의 배열의 길이가 홀수일때
        {
            for(int j = 0; j < arr.Length; j++)
            {
                if(j % 2 == 0)
                {
                    answer[j] = arr[j] + n;
                }
                else
                {
                    answer[j] = arr[j];
                }
            }
            
        }
        return answer;
    }
}