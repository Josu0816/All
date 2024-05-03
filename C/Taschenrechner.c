#include <stdio.h>
#include <stdlib.h>
int main()
{
    float erg, zahl1, zahl2;
    char op, wd;
    do
    {
        printf("Bitte 1. Zahl:");
        scanf("%f",&zahl1);
        printf("Bitte 2. Zahl:");
        scanf("%f",&zahl2);
        printf("Bitte Operator eingeben:");
        scanf("\n%c",&op);
        switch(op)
        {
            case '+':
            erg=zahl1+zahl2;
            break;
            case '-':
            erg=zahl1-zahl2;
            break;
            case '*':
            erg=zahl1*zahl2;
            break;
            case '/':
            erg=zahl1/zahl2;
            break;
            default:printf("Fehler\n");
        }
        printf("Erg=%8.3f\n",erg);
     do
      {
      printf("Wiederholen(J/N)");
      scanf("\n%c",&wd);
      }
        while((wd!='j')&&(wd!='J')&&(wd!='n')&&(wd!='N'));
    }
    while((wd=='j')||(wd=='J'));
    return 0;
}