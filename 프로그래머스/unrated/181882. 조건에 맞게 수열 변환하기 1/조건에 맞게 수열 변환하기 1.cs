using System;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[arr.Length];
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] < 50 && arr[i] % 2 != 0)//50보다 작고 홀수
            {
                answer[i] = arr[i] * 2;
            }
            else if(arr[i] >= 50 && arr[i] % 2 ==0)//50보다 크거나 같고 짝수
            {
                answer[i] = arr[i] / 2;
            }
            else//조건에 해당안되는 경우
            {
                answer[i] = arr[i];
            }
        }
        return answer;
    }
}