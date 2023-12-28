using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
        int[] answer = new int[2];
        
        for(int i = 0; i < keyinput.Length; i++)
        {
            if(keyinput[i] == "up")
            {
                if(board[1] / 2 == answer[1])
                {
                    continue;
                }
                else
                {
                    answer[1]++;
                }
            }
            else if(keyinput[i] == "down")
            {
                if(board[1] / 2 * -1 == answer[1])
                {
                    continue;
                }
                else
                {
                    answer[1]--;
                }
            }
            else if(keyinput[i] == "left")
            {
                if(board[0] / 2 * -1 == answer[0])
                {
                    continue;
                }
                else
                {
                    answer[0]--;
                }
            }
            else if(keyinput[i] == "right")
            {
                if(board[0] / 2 == answer[0])
                {
                    continue;
                }
                else
                {
                    answer[0]++;
                }
            }
        }
        return answer;
    }
}