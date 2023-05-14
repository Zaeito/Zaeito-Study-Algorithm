using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int odd = 0;
        int even = 0;
        for(int i = 0;i < num_list.Length;)//짝수
        {
            even += num_list[i];
            i += 2;
        }
        for(int i = 1;i < num_list.Length;)//홀수
        {
            odd += num_list[i];
            i += 2;
        }
        if(odd >= even)
        {
            answer = odd;
        }
        else
        {
            answer = even;
        }
        return answer;
    }
}