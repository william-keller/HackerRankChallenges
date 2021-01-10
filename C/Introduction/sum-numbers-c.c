#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main()
{
    int i, j;
    float f, g;

    if (scanf("%d %d", &i, &j) == 2 && scanf("%f %f", &f, &g) == 2)
    {
        printf("%d %d\n", i + j, i - j);
        printf("%.1f %.1f\n", f + g, f - g);
    }

    return 0;
}