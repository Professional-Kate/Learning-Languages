#include <stdio.h>

// returns a char pointer for our full char[]
char* readUserInput()
{
  // will update to actually read from a users input in the stdin. Right now hardcoded so I understand the theory
  char* string = malloc(4); // allocate 4 places in memory to our string
  string[0] = 'A';
  string[1] = 'B';
  string[2] = 'C';
  string[3] = '\0'; // null terminator so C knows where the char[] ends

  return string;
}

int main()
{
  char* returnValue = readUserInput(); // capture that pointer to be used later
  printf("%s", returnValue);
  free(returnValue); // free the memory we use for the varible so we don't memory leak

  return 0;
}
