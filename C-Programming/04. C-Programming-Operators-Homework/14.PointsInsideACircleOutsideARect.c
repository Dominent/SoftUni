#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <stdbool.h>

#define EXIT_SUCCESS 0

int main()
{
    double valX = 0;
    double valY = 0;
    double rad = 2.5;
    bool isInside = false;

    scanf("%lf", &valX);
    fflush(stdin);
    scanf("%lf", &valY);
    fflush(stdin);

    if((valX <= rad && valX  >= -rad) && (valY >= 1 && valY <= rad))
    {
        isInside = true;
    }

    printf("%s\n", isInside ? "true" : "false");

    return EXIT_SUCCESS;
}
