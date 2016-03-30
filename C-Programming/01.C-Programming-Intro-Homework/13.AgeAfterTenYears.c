#include <time.h>
#include <stdio.h>

int main (void)
{
    time_t curtime = time(NULL);
    struct tm tm = *localtime(&curtime);

    int cYear = tm.tm_year+1900;
    int cMonth = tm.tm_mon+1;
    int cDay = tm.tm_mday;

    int birthDay = 0;
    int birthMonth = 0;
    int birthYear = 0;

    scanf("%d.%d.%d", &birthDay, &birthMonth, &birthYear);

    int currAge = (cYear - birthYear);

    if(birthMonth > cMonth)
    {
        int age  = currAge - 1;

        printf("Age Now: %d\nAge After 10 Years: %d", age , age + 10);
    }
    else
    {
        int age  = currAge;

        printf("Age Now: %d\nAge After 10 Years: %d", age , age + 10);
    }

    return 0;
}
