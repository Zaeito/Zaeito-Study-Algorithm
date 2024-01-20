using System;

class Solution {
    public int solution(String my_string, String is_suffix) {
    
    if(my_string.Contains(is_suffix))
    {
        if(is_suffix[is_suffix.Length-1] == my_string[my_string.Length-1])
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    else
    {
        return 0;
    }
    }
}