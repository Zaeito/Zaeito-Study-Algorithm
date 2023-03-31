#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

// common_len은 배열 common의 길이입니다.
int solution(int common[], size_t common_len) {
    int answer = 0;
    int c = common_len - 1;
    if(common[1]-common[0] == common[2]-common[1])
    {
        answer = common[c] + (common[1] - common[0]);
        return answer;
    }
    else
    {    
        answer=common[c] * (common[1]/common[0]);
        return answer;
        
    }
    
}