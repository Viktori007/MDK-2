#include <stdio.h>
#include <math.h>

int r(int q){
    return q*3.14/180;
}

int main()
{
    double m=0,b=0,x=0,a,y,z;
    printf("введите поочередно m,b и x\n");
    scanf("%lf %lf %lf", &m, &b, &x);
    if (m==0 || b==0 || x==0) printf("Ошибка");
    
    if (a>5*b) y=a-5;
    else if (a==5*b) y=a*cos(r(a));
    else y=sin(r(a))+sin(r(b))/cos(r(b));
    
    if (m==b) a=m;
    else if (m!=b) a=exp(m+b);
    
    z=y*cos(r(y))+x*sin(r(y))+ sqrt(x*x-b);
    printf("%.02lf",z);
    return 0;
}
