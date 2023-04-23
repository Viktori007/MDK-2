#include <math.h>
#include <stdio.h>

int r(int q){
    return q*3.14/180;
}

int main()
{
    for(int x=0;x<=90;x+=10){
        printf("sin %d = %lf |",x,sin(r(x)));
        printf("cos %d = %lf\n",x,cos(r(x)));
        
    }
    return 0;
}