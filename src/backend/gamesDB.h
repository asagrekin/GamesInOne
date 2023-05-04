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
#include <string>
#include "dbObjects.h"

namespace gamesDB {
    // Clears the database of all data.
    // Returns true if succeeded, false if an error occured.
    bool clearDB();

    // Returns the list all dbObjects in the database. The user 
    // is responsible for cleaning up when they are done with it.
    // Returns nullptr if an error occurs.
    std::list<dbObject*>* getGames();

    // Erases the current database, and stores the specified list instead.
    // Parameters:
    //  games: the specified list of dbObjects to be stored in the database.
    // Returns true if succeeded, false if an error occured.
    bool storeGames(std::list<dbObject*>* games);
}
#endif