using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        for(int i = 0; i < my_string.Length; i++)
        {
            if(Char.IsLower(my_string[i]) == true)//문자가 소문자이면 true
            {
                answer += Char.ToUpper(my_string[i]);
                //해당하는 문자는 대문자로 변환
            }
            else//문자가 대문자이면 실행
            {
                answer += Char.ToLower(my_string[i]);
                //해당하는 문자는 소문자로 변환
            }
        }        
        return answer;
    }
}