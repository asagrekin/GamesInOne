# Overview
## How to use
This is an implementation of a simple data file db, built for the GamesInOne app.\
Allows users to store new platforms and games, as well as retrieve the overall list of available platforms and games, and retrieve individual platforms and games.\
DO NOT instantiate PlatformNameStruct or GameNameStruct objects on your own. They MUST be created by the database (will happen automatically on addPlatform/addGame calls). In order to get the info of specific platforms and games, first retrieve the overall list of platforms/games, then use the PlatformNameStruct/GameNameStruct of the desired game or platform, stored in the list, as the parameter for the GetPlatform or GetGame call.\
## Specific function calls
To store a new platform: call gamesDB::addPlatform(platform info stored in a PlatformStruct object)\
To store a new game: call gamesDB::addGame(game info stored in a GameStruct)\
To retrieve the overall list of platforms: call gamesDB::getPlatformNames()\
To retrieve the overall list of games: call gamesDB::getGameNames()\
To retrieve the info of a specific platform: call gamesDB::getPlatform(associated PlatformNameStruct)\
To retrieve the info of a specific game: call gamesDB::getGame(associated GameNameStruct)\
# Example
A working example of this SDK in use is implemented for you in example.cpp to be used as reference.\
To compile, run make. This may not work on windows, if so, feel free to mess around with the Makefile, just don't push any changes to it.