// BenchmarkingMethods.cpp : Define las funciones exportadas de la aplicación DLL.
//

#include "stdafx.h"

int Add(int a, int b) {
	__asm {
		mov eax, a
		add eax, b
	}
}

int Sub(int a, int b) {
	__asm {
		mov eax, a
		sub eax, b
	}
}

int Mul(int a, int b) {
	__asm {
		mov eax, a
		imul eax, b
	}
}