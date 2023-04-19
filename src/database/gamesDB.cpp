/**
 * Implementation of the gamesDB namespace. Go to gamesDB.h for documentation.
*/

#include <fstream>
#include <iostream>
#include <list>
#include <cstdlib>
#include <string>
#include "gamesDB.h"
#include "dbObjects.h"

#define INDEX_FILE "dbFiles/ind.dat"
#define LIST_FILE  "dbFiles/lst.dat"

namespace gamesDB {
    // Stores the game and it's necessary information in the databsae
    // as an object.
    // Parameters:
    //  name: string holding the name of the game (max 16 characters in length).
    //  path: string holding the path of the game (max 256 characters in length).
    //  image_path: string holding the image path of the game (max 256 characters in length).
    // Returns the resulting dbObject if succeeded, nullptr if not.
    dbObject* storeGame(std::string name, std::string path, std::string image_path) {
	    std::fstream file;
        int index;

        // Get the current index.
	    file.open(INDEX_FILE, std::ios::in | std::ios::binary);
	    if (!file) {
	    	return nullptr;
	    } else if (!file.read((char*) &index, sizeof(index))) {
            file.close();
            index = 0;
        }
        file.close();

        // Save the new index.
        index++;
        file.open(INDEX_FILE, std::ios::out | std::ios::binary);
	    if (!file) {
	    	return nullptr;
	    }
        file.write((char*) &index, sizeof(index));
        file.close();

        // Create a new dbObject instance with provided info, and save to database.
        dbObject* game = new dbObject(index, name.c_str(), path.c_str(), image_path.c_str());
        file.open(LIST_FILE, std::ios::app | std::ios::binary);
	    if (!file) {
	    	return nullptr;
	    }
        file.write((char*) game, sizeof(dbObject));
        file.close();

        return game;
    }

    // Returns the list all dbObjects in the database. The user 
    // is responsible for cleaning up when they are done with it.
    // Returns nullptr if an error occurs.
    std::list<dbObject*>* getGames() {
        std::fstream file;
        int index;
        std::list<dbObject*> *result = new std::list<dbObject*>();

        // Get the number of dbObjects stored in the databse.
	    file.open(INDEX_FILE, std::ios::in | std::ios::binary);
	    if (!file) {
	    	return nullptr;
	    } else if (!file.read((char*) &index, sizeof(index))) {
            file.close();
            return result;
        }
        file.close();

        // Get all of the dbObjects stored in database, and put them in the resulting list.
        file.open(LIST_FILE, std::ios::in | std::ios::binary);
	    if (!file) {
	    	return nullptr;
	    }
        for (int i = 0; i < index; i++) {
            dbObject* curr = new dbObject();
            file.seekg(sizeof(dbObject) * i, std::ios::beg);
            if (!file.read((char*) curr, sizeof(dbObject))) {
                file.close();
                return nullptr;
            }
            result->push_back(curr);
        }
        file.close();

        return result;
    }
}