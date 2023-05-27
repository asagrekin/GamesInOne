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

// Calls backend function to launch the specified game.
// Inputs:
//  path: the c string representing the executable path of the game.
extern "C" __declspec(dllexport) void __stdcall launchGame(const char* path);

// Copies the information from the current game into the specified int pointer and c strings.
// The current game is the current game that the overall games' list iterator is pointing to.
// Inputs:
//  id: the int* that will get the id of the current game.
//  name: the c string that will recieve the name of the current game.
//  path: the c string that will recieve the executable path of the current game.
//  imagePath: the c string that will recieve the image path of the current game.
extern "C" __declspec(dllexport) void __stdcall GetGame(int* id, char* name, char* path, char* imagePath);

// Gets the current list of games stored in the database, and sends its iterator to the beginning.
extern "C" __declspec(dllexport) void __stdcall RefreshList();

// Deletes the specified game from the overall list, and subsequently the database.
// Inputs:
//  id: (int) the unique id of the game to be deleted.
extern "C" __declspec(dllexport) void __stdcall del(int id);

// Calls the backend function to launch the specified game.
// Inputs:
//  id: (int) the unique id of the game to be launched.
extern "C" __declspec(dllexport) void __stdcall play(int id);

// Returns true if the iterator is at the end of the overall games list, or false otherwise.
extern "C" __declspec(dllexport) bool __stdcall AtEndOfList();

// Adds a new game with the specified info to the overall list, and subsequently the database.
// The game's unique id will be generated automatically.
// Inputs:
//  game_name: a c string representing the name of the game.
//  game_path: a c string representing the exectuable path of the game.
//  image_path: a c string representing the image path of the game.
extern "C" __declspec(dllexport) void __stdcall add(char* game_name, char* game_path, char* image_path);
