# Overview
This is an implementation of a simple data file db, built for the GamesInOne app.\
### namespace
gamesDB
### In order to use
- \#include "dbObjects.h"
- \#include "gamesDB.h"

## dbObject
An object that contains a game's name, executable path, and image path, as well as a unique ID based on the executable path.
### constructor
gamesDB::dbObject(name, path, image_path);
- string name: the name of the game.
- string path: the path of the executable.
- string image_path: the path of the image for the game.
### Getters
gamesDB::getID();
- returns the unique ID for the game

gamesDB::getName();
- returns the name of the game (in the form of a c string)

gamesDB::getPath()
- returns the path of the executable (in the form of a c string)

gamesDB::getImagePath() 
- returns the path of the image (in the form of a c string)

## Database Interface Functions
gamesDB::clearDB();
- clears all of the data in the database
- returns true if succesful, false if an error occured

gamesDB::getGames();
- returns the list of games currently stored in the database
- returns nullptr if an error occurs

gamesDB::storeGames(games);
- stores the specified list in the database, deleting any old data that would be stored there
- std::list<gamesDB::dbObject*>* games: the list of games to be stored in the database
- returns true if succesful, false if an error occured

## Example
A working example of this SDK in use is implemented for you in example.cpp to be used as reference.\
To compile, run make. This may not work on windows. If so, feel free to mess around with the Makefile, just don't push any changes to it.
