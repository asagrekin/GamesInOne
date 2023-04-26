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

    string add(string ame_name, string game_path, string image_path);

    BOOL play(string game_name);

    void del();

    void gameList();

}
#endif // _GAMELAUNCHER_H_