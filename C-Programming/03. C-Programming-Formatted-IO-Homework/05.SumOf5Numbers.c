#include <stdio.h>
#include <stdlib.h>

#define EXIT_SUCCESS 0

int main()
{
    double valA = 0;
    double valB = 0;
    double valC = 0;
    double valD = 0;
    double valE = 0;
    double sum = 0;

    scanf("%lf %lf %lf %lf %lf", &valA, &valB, &valC, &valD, &valE);
    sum = valA + valB + valC + valD + valE;

    printf("%lf", sum);

    return EXIT_SUCCESS;

}
