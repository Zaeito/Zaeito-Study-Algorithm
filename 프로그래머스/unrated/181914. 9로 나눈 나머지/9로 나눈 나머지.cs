using System;

public class Solution {
    public int solution(string number) {
        int answer = 0;
        for(int i =0; i < number.Length; i++)
        {
            answer = answer + number[i] - 48;//각 자라수 더함
        }
        answer = answer % 9;

        return answer;
    }
}