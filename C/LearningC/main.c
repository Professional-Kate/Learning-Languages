#include <stdio.h>

int main()
{
    //int usersAge;
    //printf("What is your favourite number? ");
    //scanf("%d", &usersAge); get user input BUT nothing after a space charater
    //printf("%d is a stupid number.\n");

    const int maxInput = 20; // don't want the user to overload the buffer
    char usersName[maxInput]; // char array of length maxInput
    printf("What is your favourite word? ");
    fgets(usersName, maxInput, stdin);
    // fgets(variable to save to, max input size, where to get the input from);
    printf("I can't believe your favourite word is: %s", usersName);
    // the issue with fgets is that it takes the enter charater as an input. Which means after the users input it will include the a line break

    return 0;
}
