#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int hp) {
    int answer = 0;
    int shp;
    int a = 5,b = 3,c = 1;
    if(hp % a != 0)
    {
        shp = hp % a;
        if(shp % b != 0)
        {
            answer = (hp / a) + (shp / b) + (shp % b);
        }
        else
        {
            answer = (hp / a) + (hp % a) / b;
        }
    }  
    else
    {
        answer = hp / a;
    }
    return answer;
}