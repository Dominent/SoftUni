#include <stdio.h>
#include <stdlib.h>

int main()
{
    double valOne = 0;
    double valTwo = 0;

    scanf("%lf %lf", &valOne, &valTwo);

    if(valOne > valTwo)
    {
        valOne += valTwo;
        valTwo = valOne - valTwo;
        valOne = valOne - valTwo ;
    }

    printf("%.2lf %.2lf", valOne, valTwo);

    return 0;
}
