//5. Write a C program to read the age of a candidate and determine whether he is eligible to cast his/her own vote.
//Test Data : 21
//Expected Output :
//Congratulation! You are eligible for casting your vote.

#include <stdio.h>   
void main()
{
  int voting_age;  

  printf("Enter the age of the candidate : ");   
  scanf("%d",&voting_age);   

  if (vote_age<18)   
  {
    printf("Sorry, You are not eligible to caste your vote.\n"); 
    
  }
  else
    printf("Congratulation! You are eligible for casting your vote.\n");  
}