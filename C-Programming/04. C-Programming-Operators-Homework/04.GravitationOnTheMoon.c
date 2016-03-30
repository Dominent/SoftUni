#include <stdio.h>
#include <stdlib.h>

#define EXIT_SUCCESS 0

int main()
{
    double input = 0;

    scanf("%lf", &input);

    double weightOnMoon = input * 0.17;

    printf("%.3lf", weightOnMoon);

    return EXIT_SUCCESS;
}
