//9. Write a C program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
//Test Data : 7 9
//Expected Output :
//The coordinate point (7,9) lies in the First quadrant.

#include <stdio.h> 
void main()
{
    int co1, co2;    // We need to Declare two integer variables 'co1' and 'co2' to store coordinates.

    printf("Input the values for X and Y coordinate : ");   // Then Ask the user to input coordinates.
    scanf("%d %d", &co1, &co2);   // Then read and store the user's input in 'co1' and 'co2'.

    if (co1 > 0 && co2 > 0)   							// Then check wether both 'co1' and 'co2' are positive.
        printf("The coordinate point (%d,%d) lies in the First quadrant.\n", co1, co2); 		// Print a message indicating the quadrant.
    else if (co1 < 0 && co2 > 0)   							// Check if 'co1' is negative and 'co2' is positive.
        printf("The coordinate point (%d,%d) lies in the Second quadrant.\n", co1, co2); 	// Print a message indicating the quadrant.
    else if (co1 < 0 && co2 < 0)   							// Check if both 'co1' and 'co2' are negative.
        printf("The coordinate point (%d, %d) lies in the Third quadrant.\n", co1, co2);		// Print a message indicating the quadrant.
    else if (co1 > 0 && co2 < 0)   							// Check if 'co1' is positive and 'co2' is negative.
        printf("The coordinate point (%d,%d) lies in the Fourth quadrant.\n", co1, co2);		// Print a message indicating the quadrant.
    else if (co1 == 0 && co2 == 0)  							 // Check if both 'co1' and 'co2' are zero.
        printf("The coordinate point (%d,%d) lies at the origin.\n", co1, co2);			// Print a message indicating that it's at the origin.
}