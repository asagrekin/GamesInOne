# Overview
This is an implementation for the backend, built for the GamesInOne app.
### Namespaces
std\
launcher

### In order to use
- \#include <Windows.h>
- \#include <iostream>
- \#include <string>
- \#include <sys/stat.h>
- \#include <stdlib.h>
- \#include <fstream>
- \#include <algorithm>
- \#include <list>
- \#include "..\database\gamesDB.h"
- \#include "..\database\dbObjects.h"

## dbFiles Folder
A folder holding the dependant database files for the testing of the program. 
## testing_Files Folder
A folder holding the dependant image files for the testing of the program. 
## Constructor
  
gamesDB::clearDB()
- This call initalizes the database in the database folder to be used for the functionality described below.
- clears all of the data in the database.
- returns true if succesful, false if an error occured.

## Backend Interface Functions
list<gamesDB::dbObject*>* get_data()
- Retrieves the current list of data stored within the database.
- Output: Current list of gamesDB::dbObject stored in the database.

void launchGame(string& path)
- Takes the given path and runs it using create proccess.
- Input: String address of the path to execute.

BOOL checkPath(string path)
- Checks to see if the given path is valid.
- Input: Game's file path to check.
- Ouput: True if the path is valid, otherwise false.

void EnhancePath(string& path, string file_type)
- Validates game is an exe file and fixes escape characters in the path.
- Inputs: A string address representing game's path (path) and a string to represent the file type (file_type).

string add(string game_name, string game_path, string image_path)
- Adds a game to the database where it is then stored.
- Inputs: The name of the game (game_name), the path of the game (game_path), and the path of the image (image_path).
- Output: A string to represent the status of the add.

BOOL play(int id)
- Plays a game stored in the database with the given id value.
- Input:  An integer value that represents the desired id of the game to play.
- Output: A boolean value that returns true if play was successful, otherwise false.

void gameList()
- Produces an updated list of dbObjects by displaying what is in the database.

string del(int id)
- Deletes a game stored in the database with the given id value.
- Input:  An integer value that represents the desired id of the game to delete.
- Output: A string to represent the status of the delete.

bool hasPath(string path)
- Checks the database to see if the given path exists.
- Input:  A string that represents the desired path to check existence of.
- Output: A boolean value that returns true if the database has the path, otherwise false.

## Makefile
This file builds the program to be able to run the overall functionality of the backend.
  
## CMakeLists.txt
This file builds the program's tests to be able to test the overall funtionality of the backend.

## Demo
A working example of the game launcher in use is implemented for you in demo.cpp to be used as reference. To compile, run make, and then run the executable to launch.
