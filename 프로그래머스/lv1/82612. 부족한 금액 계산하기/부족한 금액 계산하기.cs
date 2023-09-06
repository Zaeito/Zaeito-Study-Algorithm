using System;

class Solution
{
    public long solution(int price, int money, int count)
    {   
        long result = 0;
        for(int i = 0;i <= count;i++)
        {
            result = result + (price * i);                
        }
        
        if(result > money)
        {
            result = result - money;
        }
        else
        {
            result = 0;
        }
        return result;
    }
}