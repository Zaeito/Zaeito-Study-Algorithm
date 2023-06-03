using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int temp = num_list.Length;
        if(temp >=11)
        {
            for(int i=0;i<temp;i++)
            {
                answer = answer + num_list[i];
            }
        }
        else
        {   answer = answer + 1;
            for(int i=0;i<temp;i++)
            {
                answer = answer * num_list[i];
            }
        }
        return answer;
    }
}