//3. Write a C program to check whether a given number is positive or negative.
//Test Data : 15
//Expected Output :
//15 is a positive number

#include <stdio.h>  
void main()
{
    int num; 

    printf("Input a number : ");  
    scanf("%d", &num);  
    if (num >= 0){
        printf("%d is a positive number \n", num);   
	}
    else{
        printf("%d is a negative number \n", num); 
	}
}	