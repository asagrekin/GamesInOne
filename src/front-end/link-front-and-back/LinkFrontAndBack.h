#include <string>
#include <Windows.h>
#include <iostream>
#include <string>
#include <sys/stat.h>
#include <stdlib.h>
#include <fstream>
#include <algorithm>
#include <list>
#include "../../database/gamesDB.h"
using namespace std;
#pragma once

extern "C" __declspec(dllexport) void __stdcall launchGame(const char* path);
extern "C" __declspec(dllexport) void __stdcall GetGame(int* id, char* name, char* path, char* imagePath);
extern "C" __declspec(dllexport) void __stdcall RefreshList();
extern "C" __declspec(dllexport) void __stdcall del(int id);
extern "C" __declspec(dllexport) void __stdcall play(int id);
extern "C" __declspec(dllexport) bool __stdcall AtEndOfList();

extern "C" __declspec(dllexport) void __stdcall add(char* game_name, char* game_path, char* image_path);
