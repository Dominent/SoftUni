#include <stdio.h>
#include <stdlib.h>
#include <limits.h>

#define BAD_INPUT 1
#define EXIT_SUCCESS 0


double CheckInput()
{
    double val = 0;
    int matches = 0;

    matches = scanf("%lf", &val);
    if(matches != 1){
       printf("Bad Input\n");
       fflush(stdin);
       return BAD_INPUT;
    }
    else{
        fflush(stdin);
        return val;
    }
}

int main()
{
    double valOne = 0;
    double valTwo = 0;
    double valThree = 0;
    double sum = 0;

    valOne = CheckInput();
    if((valOne != BAD_INPUT) ||(valOne > LONG_MIN && valOne < LONG_MAX)){
        valTwo = CheckInput();
        if((valTwo != BAD_INPUT) ||(valTwo > LONG_MIN && valTwo < LONG_MAX)){
            valThree = CheckInput();
            if((valThree != BAD_INPUT) ||(valThree > LONG_MIN && valThree < LONG_MAX)){
                sum = valOne + valTwo + valThree;
            }
        }
    }

    printf("%lf\n", sum);

    return EXIT_SUCCESS;
}
