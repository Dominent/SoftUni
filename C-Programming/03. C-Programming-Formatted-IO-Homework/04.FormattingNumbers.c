#include <stdio.h>
#include <stdlib.h>

#define VALA_MAXSIZE 500
#define EXIT_SUCCESS 0
#define MAX_BITS 9

void ToBinary(int input, int size){

    int mask = 1; //0000 0001

    int i = 0;
    for(; i < size; ++i){
        putc((input & (mask << i))? '1' : '0', stdout);
    }
}

int main()
{
    int valA = 0;
    double valB = 0;
    double valC = 0;
    int matches = 0;

    matches = scanf("%3d", &valA);
    fflush(stdin);

    if((matches != 1)||((valA < 0) || (valA > VALA_MAXSIZE))){
        printf("Bad input!");
    }
    else{
            scanf("%lf", &valB);
            scanf("%lf", &valC);
    }

    printf("|%-1X |0b", valA);
    ToBinary(valA, MAX_BITS);
    printf("| %2.1lf|%-1.3lf |", valB, valC);

    return EXIT_SUCCESS;
}
