#include <stdio.h>
#include <stdlib.h>

void swap(double *valX, double *valY)
{
    double temp = *valX;
    *valX = *valY;
    *valY = temp;
}

int main()
{
    double valOne = 0;
    double valTwo = 0;
    double valThree = 0;

    scanf("%lf %lf %lf", &valOne, &valTwo, &valThree);
    fflush(stdin);

    if(valOne > valTwo && valOne > valThree)
    {
       if(valThree > valTwo) swap(&valThree, &valTwo);
    }
    else if(valTwo > valOne && valTwo > valThree)
    {
        swap(&valTwo, &valOne);
        if(valThree > valTwo) swap(&valThree, &valTwo);
    }
    else if(valThree > valOne && valThree > valTwo)
    {
         swap(&valThree, &valOne);
         if(valThree > valTwo) swap(&valThree, &valTwo);
    }

    printf("%.2lf\t%.2lf\t%.2lf\n", valOne, valTwo, valThree);

    return 0;
}
