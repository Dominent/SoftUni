#include <stdio.h>
#include <stdlib.h>

int main()
{
    double valA = 0;
    double valB = 0;
    double valH = 0;
    double area = 0;

    scanf("%lf", &valA);
    fflush(stdin);
    scanf("%lf", &valB);
    fflush(stdin);
    scanf("%lf", &valH);
    fflush(stdin);

    area = ((valA + valB) * valH) / 2;

    printf("%.2lf\n", area);

    return 0;
}
