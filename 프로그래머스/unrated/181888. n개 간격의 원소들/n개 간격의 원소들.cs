using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int storage = 0;
        int index = 0;
        if(num_list.Length % n == 0)//answer 배열의 크기지정
        {
            storage = num_list.Length / n;
        }
        else
        {
            storage = (num_list.Length / n) + 1;
        }
        int[] answer = new int[storage];
        for(int i = 0; i < storage; i++)
        {
            answer[i] = num_list[index];
            index += n;
        }
        return answer;
    }
}