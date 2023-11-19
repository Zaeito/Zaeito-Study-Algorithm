using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int[] answer = new int[numbers.Length];
        int temp = 0;
        int index = 0;
        if(direction == "right")//끝에 원소를 앞에 배치 후 나머지 배치
        {
            answer[index] = numbers[numbers.Length - 1];
            index++;
            for(int i = 0; i < numbers.Length - 1; i++)
            {   
                answer[index] = numbers[i];
                index++;
            }
        }
        else if(direction == "left")//numbers[0]을 배열 끝에배치 후 나머지 배치
        {
            answer[numbers.Length - 1] = numbers[0];
            for(int j = 1; j < numbers.Length; j++)
            {
                answer[index] = numbers[j];
                index++;
            }
        }
        return answer;
    }
}