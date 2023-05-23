using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int temp1 = 1;//모든 원소들의 곱
        int temp2 = 0;//모든 원소들의 합의 제곱
        for(int i=0;i < num_list.Length;i++)
        {
            temp1 = temp1 * num_list[i];
            temp2 = temp2 + num_list[i];
        }
        temp2 = temp2 * temp2;
        if(temp1 > temp2)
        {
            answer = 0;
        }
        else
        {
            answer = 1;
        }
        return answer;
    }
}