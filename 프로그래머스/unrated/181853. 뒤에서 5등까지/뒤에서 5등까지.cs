using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[5];
        int temp = 0;
        int length = num_list.Length;
        for(int i = 0; i < length; i++)//오름차순 정리
        {
           for(int j = i + 1; j < length; j++)
           {
               if(num_list[i] > num_list[j])
               {
                   temp = num_list[i];
                   num_list[i] = num_list[j];
                   num_list[j] = temp;
                   temp = 0;
               }
           }
        }
        for(int k = 0; k < 5; k++)//배열 복사
        {
            answer[k] = num_list[k];
        }
        return answer;
    }
}