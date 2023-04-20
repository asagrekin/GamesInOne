# Overview
## How to use
This is an implementation of a simple data file db, built for the GamesInOne app.\
Allows users to store new games, as well as retrieve the overall list of available games.
## Use cases
- Store a new game in the database:             gamesDB::storeGame(string name, string path, string image_path);\
- Retrieve the list of games in the database:   gamesDB::getGames();
## Includes
\#include dbObjects.h\
\#include gamesDB.h
# Example
A working example of this SDK in use is implemented for you in example.cpp to be used as reference.\
To compile, run make. This may not work on windows. If so, feel free to mess around with the Makefile, just don't push any changes to it.
