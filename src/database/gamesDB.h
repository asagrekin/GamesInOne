/**
 * This is a namespace to interace with the database for the GamesInOne app.
 * Use the functions as described to add games and platforms. As well as retrieve
 * the overall list of games and platforms, and retrieve specific games and platforms.
 * DO NOT try to construct the game/platform NAME objects without going through the
 * database interface.
*/
#ifndef _GAMESDB_H_
#define _GAMESDB_H_

#include <list>
#include "example.h"

namespace gamesDB {
    // Stores the digital gaming platform and it's necessary information
    // as an object in the database. Also adds the platform name to the
    // list of available platforms in the database.
    // Returns true if succeeded, flase if not.
    bool addPlatform(PlatformStruct newPlatform);

    // Stores the game and it's necessary information in the databsae
    // as an object. Also adds the name of the game to the list of
    // available games in the database.
    // Returns true if succeeded, flase if not.
    bool addGame(GameStruct newGame);

    // Returns the list of available PlatformNameStructs. The user 
    // is responsible for cleaning up when they are done with it.
    // Returns nullptr if an error occurs.
    std::list<PlatformNameStruct>* getPlatformNames();

    // Returns the list of available GameNameStructs. The user 
    // is responsible for cleaning up when they are done with it.
    // Returns nullptr if an error occurs.
    std::list<GameNameStruct>* getGameNames();

    // Returns the PlatformStruct associated with the given PlatformNameStruct.
    // User is responsible for cleanup when they're done with it.
    // If it does not exist in the database, or if another error occurs,
    // will return nullptr.
    PlatformStruct* getPlatform(PlatformNameStruct platform);

    // Returns the GameStruct associated with the given GameNameStruct.
    // User is responsible for cleanup when they're done with it.
    // If it does not exist in the database, or if another error occurs,
    // will return nullptr.
    GameStruct* getGame(GameNameStruct game);
}
#endif