#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <stdbool.h>

#define SIZE 5
#define EXIT_SUCCESS 0

void printSubSet(int startPos, int count, int input[SIZE]);

int main(){
    int numArr[SIZE];
    int count = 0;
    int startPos = 0;
    int sum = 0;
    int hasSum = false;

    int i = 0;
    for(i; i < SIZE; ++i){
        scanf("%d", &numArr[i]);
    }
    fflush(stdin);

    i = 0;
    int j = 0;
    for(i; i < SIZE; ++i){
        sum = numArr[i];
        startPos = i;
        count = 1;
        for(j = i + 1; j < SIZE; ++j){
            sum += numArr[j];
            ++count;
            if(sum == 0){
                printSubSet(startPos, count, numArr);
                hasSum = true;
                break;
            }
        }
    }

    if(hasSum == false){
        printf("no zero subset\n");
    }

    return EXIT_SUCCESS;
}

void printSubSet(int startPos, int count, int input[SIZE]){
    int endCond = startPos + count;

    int i = 0;
    for(i = startPos; i < endCond; ++i) {
        printf("%d", input[i]);
        if(i < (endCond - 1)){
            printf(" + ");
        }
        else{
            printf(" = 0\n");
        }
        fflush(stdout);
    }
}
