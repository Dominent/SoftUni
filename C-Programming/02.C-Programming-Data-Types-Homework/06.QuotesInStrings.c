#include <stdio.h>
#include <stdlib.h>

#define EXIT_SUCCESS 0

int main()
{
    char input[] = "The \"use\" of quotations causes difficulties. \\n, \\t and \\ are also special characters.";

    printf("%s", input);

    return EXIT_SUCCESS;
}
