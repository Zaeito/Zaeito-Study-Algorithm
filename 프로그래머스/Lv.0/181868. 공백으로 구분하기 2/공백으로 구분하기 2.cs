using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_string) {       
        string str=my_string.Trim();
        List<string>list=new List<string>();       
        string[]temp=str.Split(" ");        
        for(int i=0;i<temp.Length;i++)
        {
            if(temp[i]!="")
            {
                list.Add(temp[i]);
            }
        }  
        return list.ToArray();

    }
}