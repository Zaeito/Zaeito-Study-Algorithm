using System;
using System.Linq;

public class Solution {
    public string solution(string[] str_list, string ex) {
        string result = "";
        
        str_list = str_list.Where(x => !x.Contains(ex)).ToArray();
        
        for(int i = 0; i< str_list.Length; i++)
        {
            result += str_list[i];
        }
        return result;
    }
}