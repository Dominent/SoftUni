#include <stdio.h>
#include <stdlib.h>

#define EXIT_SUCCESS 0

int main()
{
    int input = 0;
    int sum = 0;

    scanf("%d", &input);
    fflush(stdin);

    int i =0;
    for(i; i < input; ++i)
    {
        int temp = 0;
        scanf("%d", &temp);
        fflush(stdin);

        sum += temp;

        free(temp);
    }

    printf("%d", sum);

    return EXIT_SUCCESS;
}
