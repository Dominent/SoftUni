#include <stdio.h>
#include <stdlib.h>

int main()
{
    unsigned int input;
    scanf("%ud", &input);
    fflush(stdin);

    int valN = 0;
    scanf("%d", &valN);
    fflush(stdin);

    int result = 0;

    int i = 1;
    for(i; i <=valN; ++i)
    {
        if(i == valN)
        {
            result = input % 10;
        }
        input /= 10;
    }

    if(result != 0)
    {
        printf("%d\n", result);
    }
    else
    {
        printf("-");
    }


    return 0;
}
