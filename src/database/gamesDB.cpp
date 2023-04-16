/**
 * Implementation of the gamesDB namespace. Go to gamesDB.h for documentation.
*/

#include <fstream>
#include <iostream>
#include <list>
#include <cstdlib>
#include "gamesDB.h"

#define PLATFORM_NAME_LIST "dbFiles/pltnmelst.dat"
#define GAME_NAME_LIST     "dbFiles/gmenmelst.dat"
#define PLATFORM_LIST      "dbFiles/pltlst.dat"
#define GAME_LIST          "dbFiles/gmelst.dat"

namespace gamesDB {
    // Stores the digital gaming platform and it's necessary information
    // as an object in the database. Also adds the platform name to the
    // list of available platforms in the database.
    // Returns true if succeeded, flase if not.
    bool addPlatform(PlatformStruct newPlatform) {
        //GET INDEX//
        // Open the binary file to be read from.
	    fstream file;
	    file.open(PLATFORM_NAME_LIST, ios::in | ios::binary);
	    if (!file) {
            // Error opening file, return false.
	    	return false;
	    }
        
        // Initiate int, and read the current number of platforms in the list.
        int index;
        if (!file.read((char*) &index, sizeof(index))) {
            // Error reading file, return false.
            return false;
        }
        file.close();

        //WRITE NEW INDEX AND PLATFORMNAMESTRUCT//
        // Initiate new PlatformNameStruct object.
        index++;
        PlatformNameStruct newPlatformName(index, newPlatform.getName());

        // Open the binary file to be written to.
	    file.open(PLATFORM_NAME_LIST, ios::out | ios::binary);
	    if (!file) {
            // Error opening file, return false.
	    	return false;
	    }

        // Write the new number of platforms into the start of the data file.
        file.write((char*) &index, sizeof(index));

        // Jump to the location to write the new PlatformNameStruct into the file.
        file.seekg(sizeof(index) + (sizeof(PlatformNameStruct) * (index - 1)), std::ios::beg);

        // Write the new number PlatformNameStruct into the data file.
        file.write((char*) &newPlatformName, sizeof(PlatformNameStruct));
        file.close();

        //WRITE NEW PLATFORMSTRUCT//
        // Open the binary file to be written to.
	    file.open(PLATFORM_LIST, ios::out | ios::binary);
	    if (!file) {
            // Error opening file, return false.
	    	return false;
	    }

        // Jump to the location to write the new PlatformNameStruct into the file.
        file.seekg(sizeof(PlatformStruct) * (index - 1), std::ios::beg);

        // Write the new number PlatformStruct into the data file.
        file.write((char*) &newPlatformName, sizeof(PlatformNameStruct));
        file.close();

        return true;
    }

    // Stores the game and it's necessary information in the databsae
    // as an object. Also adds the name of the game to the list of
    // available games in the database.
    // Returns true if succeeded, flase if not.
    bool addGame(GameStruct newGame) {return false;}

    // Returns the list of available PlatformNameStructs. The user 
    // is responsible for cleaning up when they are done with it.
    // Returns nullptr if an error occurs.
    std::list<PlatformNameStruct>* getPlatformNames() {return nullptr;}

    // Returns the list of available GameNameStructs. The user 
    // is responsible for cleaning up when they are done with it.
    // Returns nullptr if an error occurs.
    std::list<GameNameStruct>* getGameNames() {return nullptr;}

    // Returns the PlatformStruct associated with the given PlatformNameStruct.
    // User is responsible for cleanup when they're done with it.
    // If it does not exist in the database, or if another error occurs,
    // will return nullptr.
    PlatformStruct* getPlatform(PlatformNameStruct platform) {
        //GET INDEX AND NAME//
        int index = platform.getIndex();
        char* name = platform.getName();

        //OPEN THE FILE, AND RETRIEVE THE OBJECT//
        // Open the binary file to be read from.
	    fstream file;
	    file.open(PLATFORM_LIST, ios::in | ios::binary);
	    if (!file) {
            // Error opening file, return nullptr.
	    	return nullptr;
	    }

        // Seek to the location of the desired platform.
        file.seekg(sizeof(PlatformStruct) * (index - 1), std::ios::beg);

        // Initiate blank PlatformNameStruct, read from the file onto it.
        PlatformStruct* result = new PlatformStruct();
        if (!file.read((char*) result, sizeof(result))) {
            // Error reading file, return false.
            return nullptr;
        }
        file.close();

        if (strcmp(name, result->getName()) != 0) {
            // The platform recieved is not the desired one. Something went wrong.
            return nullptr;
        }

        return result;
    }

    // Returns the GameStruct associated with the given GameNameStruct.
    // User is responsible for cleanup when they're done with it.
    // If it does not exist in the database, or if another error occurs,
    // will return nullptr.
    GameStruct* getGame(GameNameStruct game) {return nullptr;}
}