#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

int main()
{
    double input[3];
    double valB = 0;
    double valC = 0;
    int minCount = 0;
    bool isZero = false;


    scanf("%lf %lf %lf", &input[0], &input[1], &input[2]);
    fflush(stdin);

    int i = 0;
    for(i; i < 3; ++i)
    {
        if(input[i] < 0)
        {
            ++minCount;
        }
        if(input[i] == 0)
        {
            isZero = true;
        }
    }

    if(isZero)
    {
        printf("%c", '0');
    }
    else
    {
        printf("%c", minCount % 2 == 0 ? '+' : '-');
    }

    return 0;
}
