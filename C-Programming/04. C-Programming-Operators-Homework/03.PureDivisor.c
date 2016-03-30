#include <stdio.h>
#include <stdlib.h>

#define TRUE 1
#define FALSE 0
#define EXIT_SUCCESS 0

int main()
{
    int input = 0;
    int isDivisable = 0;

    scanf("%d", &input);

    if((input % 9 == 0 )||(input % 11 == 0)||(input % 13 == 0))
    {
        isDivisable = TRUE;
    }
    else
    {
        isDivisable = FALSE;
    }

    printf("%d", isDivisable);

    return EXIT_SUCCESS;
}
