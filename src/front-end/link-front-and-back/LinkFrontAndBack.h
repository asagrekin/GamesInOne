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

extern "C" __declspec(dllexport) void add(char* game_name, char* game_path, char* image_path);