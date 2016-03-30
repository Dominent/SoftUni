#include <stdio.h>
#include <stdlib.h>

int main()
{
    int input = 0;

    scanf("%d", &input);

    int i = 1;
    for(i; i < input; ++i)
    {
        printf("%d\n", i);
        fflush(stdout);
    }
    return 0;
}
