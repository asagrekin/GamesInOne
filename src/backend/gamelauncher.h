// Kelby S. & Leonardo O.
// Header File for gameLauncher which Launches Games


#ifndef _GAMELAUNCHER_H_
#define _GAMELAUNCHER_H_

#include <Windows.h> 
#include <iostream>
#include <string>
#include <sys/stat.h>
#include <stdlib.h>
#include <fstream>
#include <algorithm>
#include <list>
#include "gamesDB.h"
#include "dbObjects.h"

using namespace std;

namespace launcher {


    // Takes the given path and runs it using create proccess.
    // Input: String address of the path to execute.
    void launchGame(string& path) ;


    // Checks to see if the given path is valid.
    // Input: Game's file path to check.
    // Ouput: True if the path is valid, otherwise false.
    BOOL checkPath(string path) ;


    // Validates game is an exe file and fixes escape characters in the path.
    // Input:   A string address representing game's path.
    void EnhancePath(string& path, string file_type) ;


    // used for adding a game
    // Inputs:
    // game_name: name of the game
    // game_path: path of the game
    // image_path: path of the image

    string add(string game_name, string game_path, string image_path);

    // used for launching the game
    BOOL play(int id);

    // used for deleting a game
    string del(int id);

    // used for getting updated list of dbObjects
    void gameList();

    // return the current list of gamesDB::dbObject stored in the database
    list<gamesDB::dbObject*>* get_data();

    bool hasPath(string path);

}
#endif // _GAMELAUNCHER_H_