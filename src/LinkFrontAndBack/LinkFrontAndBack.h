#include <string>
#include <Windows.h>
#include <iostream>
#include <string>
#include <sys/stat.h>
#include <stdlib.h>
#include <fstream>
#include <algorithm>
#include <list>
using namespace std;
#pragma once

extern "C" __declspec(dllexport) void launchGame(const char* path);