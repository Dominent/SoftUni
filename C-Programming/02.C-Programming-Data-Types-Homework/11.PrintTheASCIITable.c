#include <stdio.h>
#include <stdlib.h>

int main()
{
    char *ptr = malloc(sizeof(char) * 128);

    if(ptr!= NULL)
    {
        int i;
        for(i = 1; i <= 127; i++ )
        {
           ptr[i - 1] = i;
        }

        ptr[i - 1] = 0;

        printf("%s", ptr);
    }

    free(ptr);

    return 0;
}
