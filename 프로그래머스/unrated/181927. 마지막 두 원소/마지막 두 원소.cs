using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int length = num_list.Length;
        int[] answer = new int[length + 1];
        int tempA = num_list[length - 1];//끝에 원소
        int tempB = num_list[length - 2];//끝 앞에 원소
        int storage = 0;
        //배열 복사
        for(int i = 0;i < length;i++)
        {   storage = num_list[i];
            answer[i] = storage;
            storage = 0;
        }
        //조건식
        if(tempA > tempB)
        {
            storage = tempA - tempB; 
            answer[length] = storage;
        }
        else if(tempA <= tempB)
        {
            storage = (tempA * 2); 
            answer[length] = storage;
        }
        return answer;
    }
}