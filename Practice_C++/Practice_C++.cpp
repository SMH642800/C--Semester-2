#include <iostream>

int main()
{
    int* sortArrayByParityII(int* A, int ASize, int* returnSize) {
        int n = ASize;
        int* A = new A[n];
        int temp, i, j;
        for (i = 0; i < n; i++) {
            if (i % 2 == 0 || i == 0) {
                if (A[i] % 2 != 0) {
                    for (j = i + 1; j < n; j++) {
                        if (A[j] % 2 == 0) {
                            temp = A[i];
                            A[i] = A[j];
                            A[j] = temp;
                        }
                    }
                }
            }
            else {
                if (A[i] % 2 == 0) {
                    for (j = i + 1; j < n; j++) {
                        if (A[j] % 2 != 0) {
                            temp = A[i];
                            A[i] = A[j];
                            A[j] = temp;
                        }
                    }
                }
            }
        }
        for (i = 0; i < n; i++) {
            std::cout << arr[i] << " ";
        }
    }

    return 0;
}