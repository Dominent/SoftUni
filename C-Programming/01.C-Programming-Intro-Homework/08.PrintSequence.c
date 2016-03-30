#include <stdio.h>
#include <stdlib.h>

int main()
{
    for(int i = 2; i < 12; ++i)
    {
        if(i % 2 == 0)printf("%d, ", i);
        if(i % 2 != 0 & i != 11) printf("%d, ", -i);
        //last line dose not have a coma after it!
        if(i == 11)printf("%d\n", -i);
    }

    return 0;
}
