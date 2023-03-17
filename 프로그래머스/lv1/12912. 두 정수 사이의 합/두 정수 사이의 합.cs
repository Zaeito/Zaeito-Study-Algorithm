public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        if(a == b)
        {
            answer = a;
        }
        else
        {
            if(a > b)
            {
                for(int i =b;i<=a;i++)
                {
                    answer = answer + i;
                }
            }
            else if(a < b)
            {
                for(int j = a;j<=b;j++)
                {
                    answer = answer + j;
                }
            }
                
        }
        return answer;
    }
}