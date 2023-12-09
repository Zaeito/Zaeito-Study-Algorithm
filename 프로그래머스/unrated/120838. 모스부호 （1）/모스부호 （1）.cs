using System;

public class Solution {
    public string solution(string letter) {
        string answer = "";
        string[] mosletter = 
        { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
        foreach(string i in letter.Split(" "))//공백을 기준으로 자름
        {
            answer += Convert.ToChar(Array.IndexOf(mosletter, i) + 97);
        }
        return answer;
    }
}