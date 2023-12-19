using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        int temp = 100;
        Array.Sort(array);
        
        for(int i = 0; i < array.Length; i++)
        {
            if(Math.Abs(array[i] - n) < temp)
            {
                temp = Math.Abs(array[i] - n);
                answer = array[i];
            }
        }
        return answer;
    }
}