#include <stdio.h>
#include <stdlib.h>
#include <math.h>

#define BUFFER_SIZE 4
#define NUM_LENGTH 5
#define EXIT_SUCCESS 0

int main()
{
    int input = 0;
    int sum = 0;
    char lastDigInFront[NUM_LENGTH];
    char number[NUM_LENGTH];

    scanf("%4s", &number);
    //012121
    fflush(stdin);

    int i = 0;
    for(i; i < NUM_LENGTH - 1 ; ++i)
    {
       sum += number[i]  - '0'; // need to fix this!
       if(i == 0)
       {
           lastDigInFront[i] = number[NUM_LENGTH - 2];
       }
       else
       {
           lastDigInFront[i] = number[i];
       }
    }

    char revOrderNum[NUM_LENGTH] = { number[NUM_LENGTH - 2], number[NUM_LENGTH - 3],
                                    number[NUM_LENGTH - 4], number[NUM_LENGTH - 5], 0 };

    char temp[NUM_LENGTH] = {number[NUM_LENGTH - 5], number[NUM_LENGTH - 3], number[NUM_LENGTH - 4], number[NUM_LENGTH - 2], 0};

    printf("%d\n", sum);
    printf("%s\n", revOrderNum);
    printf("%s\n", lastDigInFront);
    printf("%s\n", temp);

    return EXIT_SUCCESS;
}
