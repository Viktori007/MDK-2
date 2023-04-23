#include <stdio.h>

int main()
{
    char c;
    scanf("%c",&c);
    if (c=='a') printf("Ускорение");
    else if (c=='v') printf("Скорость");
    else if (c=='S') printf("Пройдённый путь");
    else if (c=='t') printf("Затраченное время");
    else if (c=='x') printf("Абсцисса точки на Декартовой плоскости");
    else if (c=='y') printf("Ордината точки на Декартовой плоскости");
    else if (c=='z') printf("Аппликата точки в пространстве");
    else printf("Ошибка");
    return 0;
}
