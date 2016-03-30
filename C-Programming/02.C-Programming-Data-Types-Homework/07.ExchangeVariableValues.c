#include <stdio.h>
#include <stdlib.h>

int main()
{
    char valA = 5;
    char valB = 10;

    printf("Before: \n");
    printf("a = %d: \n", valA);
    printf("b = %d: \n", valB);

    valA = valA + valB;
    valB = valA - valB;
    valA = valA - valB;

    printf("After: \n");
    printf("a = %d: \n", valA);
    printf("b = %d: \n", valB);


    return 0;
}
