#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <math.h>

int main()
{
    int valX = 0;
    int valY = 0;
    int rad = 2;
    bool isInside = false;

    scanf("%d", &valX);
    fflush(stdin);
    scanf("%d", &valY);
    fflush(stdin);

    isInside = ((abs(valX) <= rad )&& (abs(valY) <= rad )) ? true : false;
    printf("%s\n", isInside ? "true" : "false");


    return 0;
}
