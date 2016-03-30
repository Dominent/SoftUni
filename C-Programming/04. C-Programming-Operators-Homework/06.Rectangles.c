#include <stdio.h>
#include <stdlib.h>

#define EXIT_SUCCESS 0

int main()
{
    double width = 0;
    double height = 0;
    double perimeter = 0;
    double area = 0;

    scanf("%lf", &width);
    fflush(stdin);
    scanf("%lf", &height);
    fflush(stdin);

    area = width * height;
    perimeter = 2 * (width + height);

    printf("%.0lf\n", perimeter);
    printf("%.1lf\n", area);

    return EXIT_SUCCESS;
}
