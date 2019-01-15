// BenchmarkingMethods.cpp : Define las funciones exportadas de la aplicación DLL.
//

#include "stdafx.h"

int add(int a, int b) {
	__asm {
		mov eax, a
		add eax, b
	}
}

int sub(int a, int b) {
	__asm {
		mov eax, a
		sub eax, b
	}
}

int mul(int a, int b) {
	__asm {
		mov eax, a
		imul eax, b
	}
}