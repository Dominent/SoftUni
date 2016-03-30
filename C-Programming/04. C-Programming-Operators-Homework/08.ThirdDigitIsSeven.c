#include <stdio.h>
#include <stdlib.h>

int main()
{
    int input = 0;

    scanf("%d", &input);

    char *isDigitSev = ((input / 100)% 10 == 7) ? "true" : "false";

    printf("%s", isDigitSev);

    return 0;
}
