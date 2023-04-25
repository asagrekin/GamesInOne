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
    // Stores the game and it's necessary information in the databsae
    // as an object.
    // Parameters:
    //  name: string holding the name of the game (max 16 characters in length).
    //  path: string holding the path of the game (max 256 characters in length).
    //  image_path: string holding the image path of the game (max 256 characters in length).
    // Returns the resulting dbObject if succeeded, nullptr if not.
    dbObject* storeGame(std::string name, std::string path, std::string image_path);

    // Returns the list all dbObjects in the database. The user 
    // is responsible for cleaning up when they are done with it.
    // Returns nullptr if an error occurs.
    std::list<dbObject*>* getGames();

    // Removes the specified game object from the database. Specified game
    // object should come from the overall list, which is retrieved from the
    // database using getGames().
    // Parameters:
    //  game: the game object representing the game to be deleted.
    // Returns the updated list of games, or nullptr if an error occured.
    std::list<dbObject*>* removeGame(dbObject* game);
}
#endif