using System;

public class Solution {
    public int solution(int a, int d, bool[] included) {
        int answer = 0;
        int len = included.Length; //배열의 길이
        for(int i = 0; i < len; i++)
        {
            if(included[i] == true)
            {
                answer += a + (d * i);
            }
        }
        
        return answer;
    }
}