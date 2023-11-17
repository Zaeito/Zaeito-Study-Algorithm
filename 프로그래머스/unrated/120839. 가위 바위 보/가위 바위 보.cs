using System;

public class Solution {
    public string solution(string rsp) {
        string answer = "";
        for(int i =0; i < rsp.Length; i++)
        {
            if(rsp[i].ToString() == "2")
            {
                answer = String.Concat(answer,"0");
            }
            else if(rsp[i].ToString() == "0")
            {
                answer = String.Concat(answer,"5");
            }
            else if(rsp[i].ToString() == "5")
            {
                answer = String.Concat(answer,"2");
            }
        }
        return answer;
    }
}