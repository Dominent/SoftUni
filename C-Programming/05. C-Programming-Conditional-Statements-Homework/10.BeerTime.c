#include <stdio.h>
#include <stdlib.h>
#include <time.h>

/*
A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt”
(an hour in range [01...12], a minute in range [00…59] and AM / PM designator)
 and prints “beer time” or “non-beer time” according to the definition above
 or “invalid time” if the time cannot be parsed.
Note that you may need to learn how to parse dates and times. Examples:
*/

#define EXIT_SUCCESS 0

int main()
{
    char designator[2];

    struct tm input;

    scanf("%2d:%2d %s", &input.tm_hour, &input.tm_min, &designator);

    if(designator[0] == 'P' && designator[1] == 'M')
    {
        if(input.tm_hour >= 1 && input.tm_min >= 0)
        {
            printf("beer time\n");
        }
        else
        {
            printf("non-beer time\n");
        }
    }
    else if(designator[0] == 'A' && designator[1] == 'M')
    {
        if(input.tm_hour < 3)
        {
            printf("beer time\n");
        }
        else
        {
            printf("non-beer time\n");
        }
    }

    return EXIT_SUCCESS;
}
