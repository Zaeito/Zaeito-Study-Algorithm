using System;

public class Solution {
    public int[] solution(int[] emergency) {
        int[] answer = new int[emergency.Length];
        int[] temp = (int[])emergency.Clone();
        int min = temp[0];
        int index = 0;
        Array.Sort(temp);//오름차순 정렬
        for(int i = 0; i < emergency.Length; i++)
        {
            for(int j = 0; j < temp.Length; j++)
            {
                if(emergency[i] == temp[j])
                {
                    answer[index] = temp.Length - j;
                    index++;
                }
            }
        }
        return answer;
    }
}