#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

#define EXIT_SUCCESS 0

int main()
{
    int input = 0;
    bool isDivisable = false;

    scanf("%d", &input);

    if(input % 5 == 0 && input % 7 == 0)
    {
        isDivisable = true;
    }
    else
    {
        isDivisable = false;
    }

    printf("%d", isDivisable);

    return 0;
}
