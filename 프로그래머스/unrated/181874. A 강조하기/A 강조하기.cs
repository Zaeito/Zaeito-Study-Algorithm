using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";
        string temp = myString.ToLower();;
        answer = temp.Replace("a", "a".ToUpper());
        return answer;
    }
}