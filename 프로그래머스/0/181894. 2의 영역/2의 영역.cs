using System;

public class Solution {
    public int[] solution(int[] arr) {
        int startPoint = Array.IndexOf(arr, 2);
        int endPoint = Array.LastIndexOf(arr, 2);
        int[] answer = new int[endPoint - startPoint + 1];
        
        if(startPoint == -1)
        {
            return new int[] { -1 };
        }
        Array.Copy(arr, startPoint, answer, 0, answer.Length);
        
        return answer;
    }
}