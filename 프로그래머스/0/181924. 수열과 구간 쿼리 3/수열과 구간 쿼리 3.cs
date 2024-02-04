using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = arr;
        
        for(int i = 0; i < queries.GetLength(0); i++)
        {
            int a = queries[i,0];
            int b = queries[i,1];
            
            int temp = answer[a];
            answer[a] = answer[b];
            answer[b] = temp;
        }
        return answer;
    }
}