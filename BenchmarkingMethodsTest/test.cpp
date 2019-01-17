#include "pch.h"

const int maxNums = 50;

TEST(AddTest, AddPositiveNumbers) {
	for (int i = 0; i < maxNums; i++)
		for (int j = 0; j < maxNums; j++)
			ASSERT_EQ(i + j, Add(i, j));
}

TEST(AddTest, AddNegativeNumbers) {
	for (int i = 0; i < maxNums; i++)
		for (int j = 0; j < maxNums; j++)
			ASSERT_EQ(-i - j, Add(-i, -j));
}

TEST(AddTest, AddChangedSignNumbers) {
	for (int i = 0; i < maxNums; i++)
		for (int j = 0; j < maxNums; j++)
			ASSERT_EQ(i - j, Add(i, -j));
}

TEST(SubTest, SubPositiveNumbers) {
	for (int i = 0; i < maxNums; i++)
		for (int j = 0; j < maxNums; j++)
			ASSERT_EQ(i - j, Sub(i, j));
}

TEST(SubTest, SubNegativeNumbers) {
	for (int i = 0; i < maxNums; i++)
		for (int j = 0; j < maxNums; j++)
			ASSERT_EQ(-i + j, Sub(-i, -j));
}

TEST(SubTest, SubChangedSignNumbers) {
	for (int i = 0; i < maxNums; i++)
		for (int j = 0; j < maxNums; j++)
			ASSERT_EQ(i + j, Sub(i, -j));
}

TEST(MulTest, MulPositiveNumbers) {
	for (int i = 0; i < maxNums; i++)
		for (int j = 0; j < maxNums; j++)
			ASSERT_EQ(i * j, Mul(i, j));
}

TEST(MulTest, MulNegativeNumbers) {
	for (int i = 0; i < maxNums; i++)
		for (int j = 0; j < maxNums; j++)
			ASSERT_EQ(i * j, Mul(-i, -j));
}

TEST(MulTest, MulChangedSignNumbers) {
	for (int i = 0; i < maxNums; i++)
		for (int j = 0; j < maxNums; j++)
			ASSERT_EQ(-(i * j), Mul(i, -j));
}