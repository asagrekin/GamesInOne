#include "pch.h"
#include <processthreadsapi.h>
#include "LinkFrontAndBack.h"
#include "../../backend/gamelauncher.h"
#include "../../database/gamesDB.h"
using namespace std;

static list<gamesDB::dbObject*>* gameList;
static list<gamesDB::dbObject*>::iterator it;

void __stdcall launchGame(const char* path) {
	cout << "Calling Launch Game" << endl;
	string pathRef(path);
	launcher::launchGame(pathRef);
}

void  __stdcall GetGame(int* id, char* name, char* path, char* imagePath)
{
	*id = (*it)->getID();

	const char* name_src = (*it)->getName();
	strcpy_s(name, strlen(name_src) + 1, name_src);

	const char* path_src = (*it)->getPath();
	strcpy_s(path, strlen(path_src) + 1, path_src);

	const char* image_src = (*it)->getImagePath();
	strcpy_s(imagePath, strlen(image_src) + 1, image_src);
	it++;
}

void __stdcall RefreshList() {
	gameList = launcher::get_data();
	it = gameList->begin();
}
 
// Ensure boolean stays the same after build optimization for release
#pragma optimize("", off)
bool __stdcall AtEndOfList() {
	bool atEnd = (it == gameList->end());
	return atEnd;
}
#pragma optimize("", on)

void __stdcall Del(int id) {
	launcher::del(id);
}

void __stdcall Play(int id) {
	launcher::play(id);
}

void __stdcall Add(char* game_name, char* game_path, char* image_path, char* status) {
	string status_ret = launcher::add(game_name, game_path, image_path);
	strcpy_s(status, strlen(status_ret.c_str())+1, status_ret.c_str());
}