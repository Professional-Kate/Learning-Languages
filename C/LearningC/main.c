#include <stdio.h>
#include <stdlib.h>

char* readUserInput(int maxInput); // prototype for our function below

int main()
{
  char* returnValue = readUserInput(255); // capture that pointer to be used later
  printf("You Wrote: %s", returnValue);
  free(returnValue); // free the memory we use for the variable so we don't memory leak

  return 0;
}

// returns a char pointer for our full string
char* readUserInput(int maxInput)
{
  char* string = malloc(maxInput); // allocate 255 places in memory for user input
  printf("Write anything you want: ");
  fgets(string, maxInput, stdin); // read something from the stdin and write that into the first argument
  int currentSize = 0;

  // looping over our string to find the '\0' character
  while (1) 
  {
    if (string[currentSize] == '\0') 
    {
      break;
    }
    currentSize++;
  }
  
  realloc(string, currentSize); // reallocate our variable to only use the amount of memory we need

  return string;
}
