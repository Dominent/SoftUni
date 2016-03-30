#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

#define NUMBER_OF_CARDS 13

int main()
{
    char cards[] = {'2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A', 0};
    bool isValid = false;
    char input = 0;

    scanf("%c", &input);
    fflush(stdin);

    int i = 0;
    for(i; i < NUMBER_OF_CARDS; i++)
    {
        if(input == cards[i])
        {
            isValid = true;
        }
    }

    printf("%s\n", isValid ? "true" : "false");
    fflush(stdout);

    return 0;
}
