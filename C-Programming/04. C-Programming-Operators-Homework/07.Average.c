#include <stdio.h>
#include <stdlib.h>

#define EXIT_SUCCESS 0

int main()
{
    int valA = 0;
    int valB = 0;
    int valC = 0;
    double average = 0;

    scanf("%d", &valA);
    scanf("%d", &valB);
    scanf("%d", &valC);

    average = (valA + valB + valC) / 3.0;

    printf("%.5lf", average);

    return EXIT_SUCCESS;
}
