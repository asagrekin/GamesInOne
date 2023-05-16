// Kelby S. & Leonardo O.
// Header File for gameLauncher which serves as the core backend.

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
#include "..\database\gamesDB.h"
#include "..\database\dbObjects.h"

using namespace std;

namespace launcher {
    // Retrieves the current list of data stored within the database.
    // Output: Current list of gamesDB::dbObject stored in the database.
    list<gamesDB::dbObject*>* get_data();


    // Takes the given path and runs it using create proccess.
    // Input: String address of the path to execute.
    void launchGame(string& path) ;


    // Checks to see if the given path is valid.
    // Input: Game's file path to check.
    // Ouput: True if the path is valid, otherwise false.
    BOOL checkPath(string path) ;


    // Validates game is an exe file and fixes escape characters in the path.
    // Inputs:   A string address representing game's path (path) and a string
    //           to represent the file type (file_type).
    void EnhancePath(string& path, string file_type) ;


    // Adds a game to the database where it is then stored.
    // Inputs: The name of the game (game_name), the path of the game (game_path),
    //         and the path of the image (image_path).
    // Output: A string to represent the status of the add.
    string add(string game_name, string game_path, string image_path);


    // Plays a game stored in the database with the given id value.
    // Input:  An integer value that represents the desired id of the game to play.
    // Output: A boolean value that returns true if play was successful, otherwise false.
    BOOL play(int id);


    // Produces an updated list of dbObjects by displaying what is in the database.
    void gameList();


    // Deletes a game stored in the database with the given id value.
    // Input:  An integer value that represents the desired id of the game to delete.
    // Output: A string to represent the status of the delete.
    string del(int id);


    // Checks the database to see if the given path exists.
    // Input:  A string that represents the desired path to check existence of.
    // Output: A boolean value that returns true if the database has the path, otherwise false.
    bool hasPath(string path);

}
#endif // _GAMELAUNCHER_H_