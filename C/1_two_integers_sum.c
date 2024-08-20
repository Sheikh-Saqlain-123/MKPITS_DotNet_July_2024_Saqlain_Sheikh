Write a C program to accept two integers and check whether they are equal or not.
Test Data : 15 15
Expected Output :
Number1 and Number2 are equal

#include <stdio.h>
int main() {
    int num1,num2;
    printf("Enter the Two Numbers :- ");
    scanf("%d%d",&num1,&num2);
    if(num1==num2){
        printf("The Numbers %d  and  %d are Equal !", num1,num2);
    }      
    else{
        printf("The Numbers %d  and  %d are  Not Equal !", num1,num2);
    }
    return 0;
}