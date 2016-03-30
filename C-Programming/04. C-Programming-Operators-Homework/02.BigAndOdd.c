#include <stdio.h>
#include <stdlib.h>

#define TRUE 1
#define FALSE 0
#define EXIT_SUCCESS 0

int main()
{
    int input = 0;
    int isOdd = 0;

    scanf("%d", &input);
    fflush(stdin);

    if(input % 2 != 0 && input > 20)
    {
        isOdd = TRUE;
    }
    else
    {
        isOdd = FALSE;
    }

    printf("%d", isOdd);

    return EXIT_SUCCESS;
}
