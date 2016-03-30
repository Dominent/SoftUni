#include <stdio.h>
#include <stdlib.h>

#define BUFFER_SIZE 30
#define EXIT_SUCCESS 0

int main()
{
    char companyName[30];
    char companyAddress[30];
    char phoneNumber[30];
    char faxNumber[30];
    char webSite[30];
    char managerFirsName[30];
    char managerLastName[30];
    int managerAge;
    char managerPhone[30];

    fgets(companyName, BUFFER_SIZE, stdin);
    fflush(stdin);
    scanf("Address: %29[^\n]", &companyAddress);
    fflush(stdin);
    scanf("Tel. %29[^\n]", &phoneNumber);
    fflush(stdin);
    scanf("Fax: %29[^\n]", &faxNumber);
    fflush(stdin);
    scanf("Web site: %29[^\n]", &webSite);
    fflush(stdin);
    scanf("Manager: %s %s (age: %d, tel. %29[^\n])",
           &managerFirsName, &managerLastName, &managerAge, &managerPhone);
    fflush(stdin);

    printf("%s", companyName);
    printf("Address: %s\n", companyAddress);
    printf("Tel. %s\n", phoneNumber);
    printf("Fax. %s\n", faxNumber);
    printf("Web site: %s\n", webSite);
    printf("Manager: %s %s (age: %d, tel. %s\n",
            managerFirsName, managerLastName, managerAge, managerPhone);

    return EXIT_SUCCESS;
}
