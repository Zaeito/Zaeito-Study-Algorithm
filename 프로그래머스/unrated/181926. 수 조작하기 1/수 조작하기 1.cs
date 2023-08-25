using System;

public class Solution {
    public int solution(int n, string control) {
        int answer = n;
        char[] charArray = new char[control.Length];
        for (int i = 0; i < control.Length; i++)
        {
            if(control[i].Equals('w'))
            {
                answer = answer + 1;
            } 
            else if(control[i].Equals('s'))
            {
                answer = answer - 1; 
            }
            else if(control[i].Equals('d'))
            {
                answer = answer + 10;
            }
            else if(control[i].Equals('a'))
            {
                answer = answer - 10;
            }
        }
         return answer;
    }
}