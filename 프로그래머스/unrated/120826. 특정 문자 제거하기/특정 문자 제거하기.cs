using System;

public class Solution {
    public string solution(string my_string, string letter) {
        string answer = "";
        char temp = letter[0];//String과 Char을 비교할수 없기 때문에 시행
        for(int i = 0; i < my_string.Length;i++)
        {
            if(my_string[i] != temp)
            {
                answer = String.Concat(answer,my_string[i]);
            }                         
        }
        return answer;
    }
}