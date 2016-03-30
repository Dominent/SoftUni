#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

int main()
{
    double eps = 0.000001;

    double valOne = 5.000041;
    double valTwo = 5.000045;

    bool areEqual = false;

    if((valTwo - valOne) <= eps)
    {
        areEqual = true;
    }

    printf("%s", areEqual ? "true" : "false");

    return 0;
}
