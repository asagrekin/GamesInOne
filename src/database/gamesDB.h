#ifndef _GAMESDB_H_
#define _GAMESDB_H_

#include <list>

namespace gamesDB {
    // Stores the digital gaming platform and it's necessary information
    // as an object in the database. Also adds the platform name to the
    // list of available platforms in the database.
    bool addPlatform(PlatformStruct);

    // Stores the game and it's necessary information in the databsae
    // as an object. Also adds the name of the game to the list of
    // available games in the database.
    bool addGame(GameStruct);

    // Returns the list of available PlatformNameStructs. The user 
    // is responsible for cleaning up when they are done with it.
    // Returns nullptr if an error occurs.
    std::list<PlatformNameStruct> getPlatformNames();

    // Returns the list of available GameNameStructs. The user 
    // is responsible for cleaning up when they are done with it.
    // Returns nullptr if an error occurs.
    std::list<GameNameStruct> getGameNames();

    // Returns the PlatformStruct associated with the given PlatformNameStruct.
    // User is responsible for cleanup when they're done with it.
    // If it does not exist in the database, or if another error occurs,
    // will return nullptr.
    PlatformStruct getPlatform(PlatformNameStruct);

    // Returns the GameStruct associated with the given GameNameStruct.
    // User is responsible for cleanup when they're done with it.
    // If it does not exist in the database, or if another error occurs,
    // will return nullptr.
    GameStruct getGame(GameNameStruct);
}
#endif