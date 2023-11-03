using System;

public class Solution {
    public string[] solution(string[] names) {
        int length = 0;
        int index = 0;
        if(names.Length % 5 == 0)//배열의 길이 정하기
        {
            length = names.Length / 5;
        }
        else
        {
            length = names.Length / 5 + 1;
        }
        string[] answer = new string[length];
        for(int i = 0;i < length; i++)
        {
            answer[i] = names[index];
            index += 5;
        }
        return answer;
    }
}