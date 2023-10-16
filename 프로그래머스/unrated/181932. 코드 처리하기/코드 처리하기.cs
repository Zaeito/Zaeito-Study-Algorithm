using System;

public class Solution {
    public string solution(string code) {
        string answer = "";
        string ret = "EMPTY";
        int mode = 0;
        for(int i = 0; i < code.Length;i++)
        {
            if(mode % 2 == 0)//mode가 0일 때
            {   
               if(code[i] == '1')
               {
                   mode = 1;
               }
               else
               {
                   if(i % 2 == 0)//인덱스 번호가 짝수인 경우만
                   {
                       answer = String.Concat(answer,code[i]);
                   }
               }
                
            }
            else//mode가 1일때
            {
                if(code[i] == '1')
                {
                    mode = 0;
                }
                else
                {
                    if(i % 2 == 1)//인덱스 번호가 홀수인 경우만
                    {
                        answer = String.Concat(answer,code[i]);
                    }
                }
            }
        }
        
        if(answer == "")
        {
            answer = String.Concat(answer,ret);
        }
        return answer;
    }
}