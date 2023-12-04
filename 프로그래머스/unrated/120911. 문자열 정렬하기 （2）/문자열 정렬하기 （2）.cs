using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        string temp = my_string.ToLower();
        string answer = String.Concat(temp.OrderBy(ch=>ch));
        return answer;
    }
}