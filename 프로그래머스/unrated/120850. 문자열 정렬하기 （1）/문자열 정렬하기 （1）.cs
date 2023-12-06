using System;
using System.Text.RegularExpressions;
using System.Linq;

public class Solution {
    public int[] solution(string my_string) {
        String temp = my_string;
        int index = 0;
        temp = Regex.Replace(temp, @"\D", "");
        int[] answer = new int[temp.Length];
        for(int i =0; i < temp.Length; i++)
        {
            answer[index] = int.Parse(temp[i].ToString());
            index++;
        }
        answer = answer.OrderBy(n => n).ToArray();
        return answer;
    }
}