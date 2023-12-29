using System;

public class Solution {
    public int[] solution(int[,] score) {
       int[] answer = new int[score.GetLength(0)];
        Array.Fill(answer, 1);//배열 전체에 1로 채우기
        
        for(int i = 0; i < score.GetLength(0); i++)
        {
            for(int j = 0; j < score.GetLength(0); j++)
            {
                if(score[i, 0] + score[i, 1] > score[j, 0] + score[j, 1])
                {
                    answer[j]++;
                }
            }
        }
        return answer;
    }
}