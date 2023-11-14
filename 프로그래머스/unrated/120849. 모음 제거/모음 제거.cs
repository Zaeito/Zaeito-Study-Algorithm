using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        string[] temp = new string[] {"a","e","i","o","u"};
        for(int i = 0; i < my_string.Length; i++)
        {
            if(my_string[i].ToString() == temp[0])
            {
            
            }
            else if(my_string[i].ToString() == temp[1])
            {
                    
            }
            else if(my_string[i].ToString() == temp[2])
            {
                    
            }
            else if(my_string[i].ToString() == temp[3])
            {
                    
            }
            else if(my_string[i].ToString() == temp[4])
            {
                    
            }
            else
            {
                answer = String.Concat(answer,my_string[i]);
            }
        }
        return answer;
    }
}