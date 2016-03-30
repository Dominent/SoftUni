#include <stdio.h>
#include <stdlib.h>

int main()
{
    int input = 0;
    char string[256];
    double valD = 0;
    int valI = 0;

    printf("Please choose a type:\n");
    printf("1 --> int\n");
    printf("2 --> double\n");
    printf("3 --> string\n");

    scanf("%d", &input);
    fflush(stdin);

    switch(input)
    {
        case 1:
            printf("Please enter a int:\n");

            scanf("%d", &valI);
            fflush(stdin);

            printf("%d\n", ++valI);

            break;
        case 2:
            printf("Please enter a double:\n");

            scanf("%lf", &valD);
            fflush(stdin);

            printf("%lf\n", ++valD);

            break;
        case 3:
            {
                printf("Please enter a string:\n");

                scanf("%s", &string);
                fflush(stdin);

                int i = 0;
                for(i; ; i++)
                {
                    if(string[i] == 0)
                    {
                        string[i] = '*';
                        string[i + 1] = 0;
                        break;
                    }
                }

                printf("%s\n", string);
            }
            break;
        default :
            {
                printf("Wrong input\n");
                return -1;
            }
            break;
    }

    return 0;
}
