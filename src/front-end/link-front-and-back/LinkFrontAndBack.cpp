#include "pch.h"
#include <processthreadsapi.h>
#include "LinkFrontAndBack.h"
#include "../../backend/gamelauncher.h"
using namespace std;


void launchGame(const char* path) {
	cout << "Calling Launch Game";
	string pathRef(path);
	launcher::launchGame(pathRef);
}