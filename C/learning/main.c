#include <stdio.h> // allows us to use printf


// main() is the entrypoint of our program
int main() 
{
  char myName[] = "Katie"; // char array of my name : string. Each charater has a place in memory, the whole string isn't stored at one memory address 
  int myAge = 22.3;
  printf("Hello there, my name is %s\n", myName); // %s is replaced with the string. %s is the identifier for a string being interpolated into the string
  printf("%s is %d years old \n", myName, myAge); // %d is the same as above but this time with an intiger. %d or %s is a format specifier. Got the real name, I think 

  // data types
  char a = 'a'; // single charater. Use '' 
  char string[] = "string"; // charater array which makes a string
  int seventeen = 17; // intiger : whole number
  double weakerFloat = 123.2344445; // 6 point precision. Everything after the 6th dp is dropped
  float strongerDouble = 123.234444534342354325; // 24 point precision, I think? 

  printf("%f \n", pow(3, 2)); // 3^2
  printf("%f", ceil(34.4545)); // normal mathamatical operations. floor() ceil() pow()

  int canChange = 14;
  canChange = 24; // this is okay
  const int cantChange = 23;
  // cantChange = 43; this is not okay

  return 0; // 0 == everything okay! Exit success
}