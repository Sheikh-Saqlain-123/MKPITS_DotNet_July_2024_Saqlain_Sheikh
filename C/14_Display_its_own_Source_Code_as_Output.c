//C Program to Display its own Source Code as Output#include <stdio.h>
 

 
#include <stdio.h>
int main()
{
    FILE *fp;
    char ch;
 
    fp = fopen(__FILE__,"r");
    do
    {
        ch = getc(fp);
        putchar(ch);
     }
     while (ch != EOF);
     fclose(fp);
     return 0;
}