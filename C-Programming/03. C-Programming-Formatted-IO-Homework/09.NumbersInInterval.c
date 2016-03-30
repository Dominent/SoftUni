#include <stdio.h>
#include <stdlib.h>

#define EXIT_SUCCESS 0

int main()
{
    unsigned int valA = 0;
    unsigned int valB = 0;
    int count = 0;

    scanf("%ud", &valA);
    fflush(stdin);
    scanf("%ud", &valB);
    fflush(stdin);

    unsigned int i = valA;
    for (i; i < valB; i++)
    {
        if(i % 5 == 0)
        {
            ++count;
        }
    }

    printf("%d", count);

    return EXIT_SUCCESS;
}
