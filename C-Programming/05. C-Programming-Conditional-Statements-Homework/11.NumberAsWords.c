#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <stdbool.h>

#define EXIT_SUCCESS 0

bool isEmpty(char* string){
    bool temp = false;

    int i = 0;
    if(strcmp(string, "NULL") == 0){
        temp = true;
    }

    return temp;
}

void addWhiteSpace(char* string, char* concStr){
    strcat(string, " ");
    strcat(string, concStr);
}

int main(){
    char* oneToTwelve[9] = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    char* twentyToHundr[9] = { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
    char* elevenToTwenty[9] = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
    char* exT[3] = { "and", "teen", "hundred" };

    int input = 0;
    int hundreds = 0;
    int decimals = 0;
    int ones = 0;
    int matches = 0;
    char output[30] = "NULL";

    printf("Enter a number: ");
    fflush(stdout);

    matches = scanf("%d", &input);
    fflush(stdin);

    if(matches == 1){
        hundreds = input / 100;
        decimals = (input / 10) % 10;
        ones = (input % 10) % 10;

        if( hundreds > 0 ){
            strcpy(output, oneToTwelve[hundreds - 1]);
            addWhiteSpace(output, exT[3 - 1]);
        }
        if(decimals == 1 && (ones > 0 && ones < 10)){
            if(isEmpty(&output)) strcpy(output, elevenToTwenty[ones - 1]);
            else{
                addWhiteSpace(output, exT[0]);
                addWhiteSpace(output, elevenToTwenty[ones - 1]);
            }
        }
        else{
            if( decimals > 0){
                if(isEmpty(&output)) strcpy(output, twentyToHundr[decimals - 1]);
                else{
                    addWhiteSpace(output, exT[0]);
                    addWhiteSpace(output, twentyToHundr[decimals - 1]);
                }
            }
            if( ones > 0 ){
                if(isEmpty(&output)) strcpy(output, oneToTwelve[ones - 1]);
                else addWhiteSpace(output, oneToTwelve[ones - 1]);
            }
        }
    }

    output[0] = toupper(output[0]);
    printf("%s\n", output);
    fflush(stdout);

    return EXIT_SUCCESS;
}
