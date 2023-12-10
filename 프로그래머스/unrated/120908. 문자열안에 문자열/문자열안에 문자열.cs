using System;

public class Solution {
    public int solution(string str1, string str2) {
        int answer = 0;
        if(str1.Contains(str2) == true)//Contains는 해당 문자열이 존재하면 true를 아니면 false의 값이 나온다.
        {
            answer = 1;
        }
        else
        {
            answer = 2;
        }
        return answer;
    }
}