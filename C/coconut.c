#include <stdio.h>
#define SECRET 1234

int main(int argc, char ** argv){
	if(HALLO /*needs compiler input*/ + 1233 == SECRET){
		printf("Sie haben gewonnen!\n");
	}else{
		printf("Leider nein!\n");
	}

	/*compile with gcc -o <name> coconut.c -DHALLO=<value>*/

	return 0;
}