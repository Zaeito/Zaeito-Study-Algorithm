using System;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        int answer = 0;
        if(my_string.Length < is_prefix.Length)//길이가 오버하면 같지 않음
        {
            answer = 0;
        }
        else//미리 1의 값을 줌
        {   answer = 1;
            for(int i = 0; i < is_prefix.Length; i++)
            {
                if(my_string[i] != is_prefix[i])//같지 않으면 0을 리턴
                {
                    answer = 0;
                }
            }
        }
        return answer;
    }
}