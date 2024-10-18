//C Program to Calculate EMI
#include <stdio.h>
#include <math.h>

float calculateEMI(float principal, float rate, int months) {
    float monthlyRate = rate / (12 * 100); // Monthly interest rate
    float emi = (principal * monthlyRate * pow(1 + monthlyRate, months)) / (pow(1 + monthlyRate, months) - 1);
    return emi;
}

int main() {
    float principal, rate, emi;
    int months;

    printf("Enter the loan amount: ");
    scanf("%f", &principal);

    printf("Enter the annual interest rate (in percentage): ");
    scanf("%f", &rate);

    printf("Enter the loan tenure (in months): ");
    scanf("%d", &months);

    emi = calculateEMI(principal, rate, months);

    printf("The EMI is: %.2f\n", emi);

    return 0;
}
