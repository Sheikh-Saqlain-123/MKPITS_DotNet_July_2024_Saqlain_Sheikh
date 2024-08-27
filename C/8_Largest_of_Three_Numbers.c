//8. Write a C program to find the largest of three numbers.
//Test Data : 12 25 52
//Expected Output :
//1st Number = 12,        2nd Number = 25,        3rd Number = 52
//The 3rd Number is the greatest among three

#include <stdio.h>   

void main()
{
    int num1, num2, num3;  

    printf("Enter the values for three numbers : ");   
    scanf("%d %d %d", &num1, &num2, &num3);   
    printf("1st Number = %d,\t2nd Number = %d,\t3rd Number = %d\n", num1, num2, num3);  

    if (num1 > num2)   
    {
        if (num1 > num3)   
        {
            printf("The 1st Number is the greatest among three. \n");   
        }
        else
        {
            printf("The 3rd Number is the greatest among three. \n");   
        }
    }
    else if (num2 > num3) {
        printf("The 2nd Number is the greatest among three \n");   
    }
    else{
        printf("The 3rd Number is the greatest among three \n");   
    }  
}