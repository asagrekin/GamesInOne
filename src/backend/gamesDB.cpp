/**
 * Implementation of the gamesDB namespace. Go to gamesDB.h for documentation.
*/
#include "pch.h"
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
    bool clearDB() {
        // Clear the list file.
        std::fstream file;
        file.open(LIST_FILE, std::ios::out | std::ios::binary);
	    if (!file) {
	    	return false;
	    }
        file.close();

        // Clear the index file, and set the number of games to 0.
        int index = 0;
	    file.open(INDEX_FILE, std::ios::out | std::ios::binary);
	    if (!file) {
	    	return false;
	    }
        file.write((char*) &index, sizeof(index));
        file.close();

        return true;
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
            delete result;
	    	return nullptr;
	    } else if (!file.read((char*) &index, sizeof(index))) {
            file.close();
            return result;
        }
        file.close();

        // Get all of the dbObjects stored in database, and put them in the resulting list.
        file.open(LIST_FILE, std::ios::in | std::ios::binary);
	    if (!file) {
            delete result;
	    	return nullptr;
	    }
        for (int i = 0; i < index; i++) {
            dbObject* curr = new dbObject();
            file.seekg(sizeof(dbObject) * i, std::ios::beg);
            if (!file.read((char*) curr, sizeof(dbObject))) {
                file.close();
                delete result;
                return nullptr;
            }
            result->push_back(curr);
        }
        file.close();

        return result;
    }

    // Erases the current database, and stores the specified list instead.
    // Parameters:
    //  games: the specified list of dbObjects to be stored in the database.
    // Returns true if succeeded, false if an error occured.
    bool storeGames(std::list<dbObject*>* games) {
        // Open the file to be written to, erasing old contents.
        std::fstream file;
        file.open(LIST_FILE, std::ios::out | std::ios::binary);
	    if (!file) {
	    	return false;
	    }

        // Iterate through the new list of dbObjects, and store each one in the database.
        for (std::list<gamesDB::dbObject*>::iterator it = games->begin(); it != games->end(); ++it) {
            file.write((char*) (*it), sizeof(dbObject));
        }
        file.close();

        // Write the new number of games in the index file.
        int index = games->size();
        file.open(INDEX_FILE, std::ios::out | std::ios::binary);
	    if (!file) {
	    	return false;
	    }
        file.write((char*) &index, sizeof(index));
        file.close();

        return true;
    }
}