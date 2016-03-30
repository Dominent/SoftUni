#include <stdio.h>
#include <stdlib.h>

#define EXIT_SUCCESS 0

int main()
{
    int input = 0;
    int prevFiboNum = 0;
    int currFiboNum = 1;

    scanf("%d", &input);

    int i = 0;
    for(i; i < input; ++i)
    {
        if(i != 0)
        {
            prevFiboNum += currFiboNum;
        }
        printf("%d\n", prevFiboNum);

        currFiboNum += prevFiboNum;
        printf("%d\n", currFiboNum);
    }
    return EXIT_SUCCESS;
}
