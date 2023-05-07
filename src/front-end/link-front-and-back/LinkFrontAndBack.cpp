#include "pch.h"
#include <processthreadsapi.h>
#include "LinkFrontAndBack.h"
#include "../../backend/gamelauncher.h"
#include "../../backend/gamesDB.h"
using namespace std;


void launchGame(const char* path) {
	cout << "Calling Launch Game" << endl;
	string pathRef(path);
	launcher::launchGame(pathRef);
}

//const char* add(const char* game_name, const char* game_path, const char* image_path) {
//	cout << "Adding " << game_name << endl;
//	//string addStatus = launcher::add(string(game_name), string(game_path), string(image_path));
//	//cout << "Add Status: " << addStatus << endl;
//	string addStatus = "test";
//	return addStatus.c_str();
//}
void add(char* game_name, char* game_path, char* image_path) {
	launcher::get_data();
	//gamesDB::getGames();
	cout << "Adding " << game_name << endl;
	string name = game_name;
	string game = game_path;
	string image = image_path;
	string status = launcher::add(game_name, game_path, image_path);
	cout << "status: " << status << endl;
	launcher::gameList();
}