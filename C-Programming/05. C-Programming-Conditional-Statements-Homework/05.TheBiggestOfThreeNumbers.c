#include <stdio.h>
#include <stdlib.h>
#include <limits.h>

#define SIZE 3
#define INT_MIN -2147483646

int main()
{
    double input[SIZE];
    double max_val = INT_MIN;

    scanf("%lf %lf %lf", &input[0], &input[1], &input[2]);
    fflush(stdin);

    int i = 0;
    for(i; i < SIZE; i++)
    {
        if(input[i] > max_val)
        {
            max_val = input[i];
        }
    }

    printf("%.2lf\n", max_val);
    fflush(stdout);

    return 0;
}
