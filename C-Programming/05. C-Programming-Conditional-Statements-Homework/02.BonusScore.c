#include <stdio.h>
#include <stdlib.h>

int main()
{
    int input = 0;
    scanf("%d", &input);

    if(input >= 1 && input <= 3 ) input *= 10;
    if(input >= 4 && input <= 6 ) input *= 100;
    if(input >= 7 && input <= 9 ) input *= 1000;
    if(input == 0 && input > 9 ) input = -1;

    if( input != -1) printf("%d", input);
    else printf("invalid score");

    return 0;
}
