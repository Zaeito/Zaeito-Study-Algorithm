using System;

public class Solution {
    public string solution(int age) {
        string temp = age.ToString();
        string answer = "";
        for(int i = 0; i < temp.Length; i++)
        {
            if(temp[i].ToString() == "0")
            {
                answer = String.Concat(answer,"a");
            }
            else if(temp[i].ToString() == "1")
            {
                answer = String.Concat(answer,"b");
            }
            else if(temp[i].ToString() == "2")
            {
                answer = String.Concat(answer,"c");
            }
            else if(temp[i].ToString() == "3")
            {
                answer = String.Concat(answer,"d");
            }
            else if(temp[i].ToString() == "4")
            {
                answer = String.Concat(answer,"e");
            }
            else if(temp[i].ToString() == "5")
            {
                answer = String.Concat(answer,"f");
            }
            else if(temp[i].ToString() == "6")
            {
                answer = String.Concat(answer,"g");
            }
            else if(temp[i].ToString() == "7")
            {
                answer = String.Concat(answer,"h");
            }
            else if(temp[i].ToString() == "8")
            {
                answer = String.Concat(answer,"i");
            }
            else if(temp[i].ToString() == "9")
            {
                answer = String.Concat(answer,"j");
            }
        }
        return answer;
    }
}