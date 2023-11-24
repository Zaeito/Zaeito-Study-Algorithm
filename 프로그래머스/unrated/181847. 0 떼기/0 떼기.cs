using System;

public class Solution {
    public string solution(string n_str) {
        string answer = "";
        int index = 0;
        if(n_str[0].ToString() == "0")//첫번째가 0인지 판별
        {
            for(int i = 0; i < n_str.Length; i++)//0이 끝나는 지점 파악
            {
                if(n_str[i].ToString() != "0")
                {
                    index = i;
                    break;
                }
            }
            for(int j = index; j < n_str.Length; j++)//0이 아닌 부분부터 출력
            {
                answer = String.Concat(answer,n_str[j]);
            }
        }
        else//첫번째가 0이 아니면
        {
            answer = String.Concat(answer,n_str);
        }
        return answer;
    }
}