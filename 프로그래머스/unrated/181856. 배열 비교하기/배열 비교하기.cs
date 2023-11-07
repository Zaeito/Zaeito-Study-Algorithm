using System;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        int answer = 0;
        int temp = 0;
        if(arr1.Length != arr2.Length)//배열의 길이가 다를때
        {
            if(arr1.Length > arr2.Length)
            {
                answer = 1;
            }
            else
            {
                answer = -1;
            }
        }
        else//배열의 길이가 같을 때
        {
            for(int i =0;i<arr1.Length;i++)
            {
                answer += arr1[i];
                temp += arr2[i];
            }
            if(answer > temp)
            {
                answer = 1;
            }
            else if(answer < temp)
            {
                answer = -1;
            }
            else
            {
                answer = 0;
            }
        }
        
        return answer;
    }
}