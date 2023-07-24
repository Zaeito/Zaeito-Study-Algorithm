#include <stdio.h>
#define LEN_INPUT 20

int main(void) {
    char s1[LEN_INPUT];
    int i;
    scanf("%s", s1);
    for(i=0;s1[i]; i++)
    {
        if((s1[i]>='a')&&(s1[i]<='z'))
        {
            s1[i] = s1[i]-'a'+'A';
        }
        else
        {
            if((s1[i]>='A')&&(s1[i]<='Z'))
            {
                s1[i] = s1[i]-'A'+'a';
            }
        }
    }
    printf("%s\n",s1);
    return 0;
}
