#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int* solution(int n) {
    // return 값은 malloc 등 동적 할당을 사용해주세요. 할당 길이는 상황에 맞게 변경해주세요.
    int* answer = (int*)malloc(sizeof(int) * (n/2+1));
          
      if(n % 2 == 0)//짝수
      {
         for(int i = 1;i <= n;)
         {
             for(int a = 0;a < n/2;a++)
             {
                 answer[a] = i;
                 i += 2;
             }
             
         }
      }
      else//홀수
      {
        for(int j = 1;j <= n;)
         {
             for(int b = 0;b < (n/2+1);b++)
             {
                 answer[b] = j;
                 j += 2;
             }
             
         }
      }  
    return answer;
    free(answer);
    
}