//7. Write a C program to accept the height of a person in centimeters and categorize the person according to their height.
//Test Data : 135
//Expected Output :
//The person is Dwarf.

#include <stdio.h>   
void main()
{
   float height;   
   printf("Enter the  Height of the Person in Centimeters :");  
   scanf("%f",&height);   
   if(height<150.0)
   {
        printf("The Person Dwarf ! \n");
   }
    else if ((height>=150.0) && (height<165.0)) {
         printf("The Person's Height is Average ! \n");
    }
    else if((height>165.0) && (height<=195.0)){
         printf("The Person Tall ! \n");
    }
   else{
       printf("The Person's Height is Not Normal ! \n");
   }

}