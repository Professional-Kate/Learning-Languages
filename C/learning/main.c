#include <stdio.h> // allows us to use printf

int main() 
{
  char myName[] = "Katie"; // char array of my name : string. Each charater has a place in memory, the whole string isn't stored at one memory address 
  int myAge = 22;
  printf("Hello there, my name is %s\n", myName); // %s is replaced with the string. %s is the identifier for a string being interpolated into the string
  printf("%s was %d years old \n", myName, myAge); // %d is the same as above but this time with an intiger
  return 0; // 0 == everything okay! Exit success
}