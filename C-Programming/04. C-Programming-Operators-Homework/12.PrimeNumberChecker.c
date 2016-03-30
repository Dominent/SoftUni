#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <math.h>

int main()
{
    int input = 0;
    bool isPrime = true;

    scanf("%d", &input);
    fflush(stdin);

    if(input <= 1)
    {
        isPrime = false;
    }
    else
    {
        int i = 2;
        for(i; i <= sqrt(input); ++i)
        {
            if(input % i == 0)
            {
                isPrime = false;
                break;
            }
        }
    }



    printf("%s", isPrime ? "true" : "false");

    return 0;
}
