using System;

public class Solution {
    public string[] solution(string[] todo_list, bool[] finished) {
        int temp = 0;
        int index = 0;
        for(int i = 0; i < finished.Length; i++)          
        {
            if(finished[i] == false)
            {
                temp += 1;
            }
        }
        string[] answer = new string[temp];
        for(int j = 0; j < finished.Length; j++)
        {
            if(finished[j] == false)
            {
                answer[index] = todo_list[j];
                index++;
            }
        }
        return answer;
    }
}