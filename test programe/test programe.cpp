#include<stdio.h>

int main(void)
{
	FILE**fp;
	fp = fopen_s("text.txt", "w");
	fprintf(fp, "Hello world!");
	fclose(fp);

	return 0;
}

