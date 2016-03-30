#include <stdio.h>
#include <stdlib.h>
#include <math.h>

#define PI 3.14159265
#define EXIT_SUCCESS 0

int main()
{
    double rad = 0;
    double perimeter = 0;
    double area = 0;

    scanf("%lf", &rad);

    perimeter =  2 * PI * rad;
    area = PI * pow(rad, 2);

    printf("Perimeter: %.2lf\n", perimeter);
    printf("Area: %.2lf\n", area);

    return EXIT_SUCCESS;
}
