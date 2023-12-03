using System;

public class Solution {
    public int[] solution(int[] arr) {
        int storage = 0;//배열의 크기
        int temp = 0;
        int index = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            storage = storage + arr[i];
        }
        int[] answer = new int[storage];
        for(int j=0; j < arr.Length; j++)
        {
            for(int k = 0; k < arr[j]; k++)
            {
                answer[index] = arr[j];
                index += 1;
            }
        }
        return answer;
    }
}