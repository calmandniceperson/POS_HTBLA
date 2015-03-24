#include <stdio.h>

int main(int argc, char **argv){
	char str[15];
	sprintf(str, "%d" , NUM1 + NUM2);
	printf(str,"\n");

	/*compile with gcc -o <name> calc.c -DNUM1=<value> -DNUM2=<value>*/

	return 0;
}