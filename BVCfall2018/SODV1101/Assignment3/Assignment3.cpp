#include <iostream>
using namespace std;

const int ARRSIZE = 16;
const int LAND = 1;

int IslandArea(int map[], int width, int height) {
	int area;

	for (int i = 0; i < (width * height); i++) {
		if (map[i] == LAND) {
			area++;
		}
	}

	return area;
}

int IslandPerimeter(int map[], int width, int height) {

	int perimeter = 0;

	for (int i = 0; i < ARRSIZE; i++) {

		const int UP = i - width;
		const int DOWN = i + width;
		const int LEFT = i - 1;
		const int RIGHT = i + 1;

		if (map[i] == LAND) {

			if (LEFT > -1 && map[LEFT] == LAND) {
				perimeter -= 1;
			}
			if (RIGHT < ARRSIZE && map[RIGHT] == LAND) {
				perimeter -= 1;
			}
			if (UP > -1 && map[UP] == LAND) {
				perimeter -= 1;
			}
			if (DOWN < ARRSIZE && map[DOWN] == LAND) {
				perimeter -= 1;
			}

			if (map[LEFT] == LAND && map[LEFT] % width == 0) {
				perimeter += 1;
			}

			if (map[RIGHT] == LAND && map[LEFT] % width == 0) {
				perimeter += 1;
			}

			perimeter += width;

		}
	}

	return perimeter;
}

void IslandShrink(int map[], int width, int height) {

	int tempMap[width * height];

	for (int i = 0; i < (width * height); i++) {
		tempMap[i] = map[i];
	}

	for (int j = 0; j < (width * height); j++) {

		const int UP = j - height;
		const int DOWN = j + height;
		const int LEFT = j - 1;
		const int RIGHT = j + 1;

		if (map[RIGHT] == 0 || map[LEFT] == 0 || map[UP] == 0 || map[DOWN] == 0) {
			tempMap[j] = 0;
		}
		else if (RIGHT > ARRSIZE || LEFT > ARRSIZE || UP > ARRSIZE || DOWN > ARRSIZE) {
			tempMap[j] = 0;
		}

	}

	for (int h = 0; h < (width * height); h++) {
		map[h] = tempMap[h];
	}

}

int main() {
	const int MAP_WIDTH = 4;
	const int MAP_HEIGHT = 4;
	int map[MAP_WIDTH * MAP_HEIGHT] = {
	  0, 0, 1, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0
	};
	cout << "Area:      " << IslandArea(map, MAP_WIDTH, MAP_HEIGHT) << endl;
	cout << "Perimeter: " << IslandPerimeter(map, MAP_WIDTH, MAP_HEIGHT) << endl;
	IslandShrink(map, MAP_WIDTH, MAP_HEIGHT);
	for (int i = 0; i < MAP_WIDTH * MAP_HEIGHT; ++i) {
		cout << map[i];
		if ((i + 1) % MAP_WIDTH == 0)
			cout << endl;
	}
	return 0;
}