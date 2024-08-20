//2. Write a C program to check whether a given number is even or odd.
//Test Data : 15
//Expected Output :
//15 is an odd integer

#include <stdio.h>
int main() {
    int num;
    printf("Enter the  Number :- ");
    scanf("%d",&num);
    if(num%2==0){
        printf("The Number %d  is Even Integer!", num);
    }
    else{
        printf("The Number %d  is Odd Integer!",num);
    }
    return 0;
}