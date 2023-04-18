/**
 * Implementation of the gamesDB namespace. Go to gamesDB.h for documentation.
*/

#include <fstream>
#include <iostream>
#include <list>
#include <cstdlib>
#include "gamesDB.h"
#include "example.h"

#define PLATFORM_NAME_LIST "dbFiles/pltnmelst.dat"
#define GAME_NAME_LIST     "dbFiles/gmenmelst.dat"
#define PLATFORM_LIST      "dbFiles/pltlst.dat"
#define GAME_LIST          "dbFiles/gmelst.dat"
#define PLATFORM_INDEX     "dbFiles/pltInd.dat"
#define GAME_INDEX         "dbFiles/gmeInd.dat"

#define NAME_SIZE 17
#define USERNAME_SIZE 17
#define PASSWORD_SIZE 65
#define PATH_SIZE 257

namespace gamesDB {
    // Stores the digital gaming platform and it's necessary information
    // as an object in the database. Also adds the platform name to the
    // list of available platforms in the database.
    // Returns true if succeeded, flase if not.
    bool addPlatform(PlatformStruct newPlatform) {
        //GET INDEX//
        // Open the binary file to be read from.
	    fstream file;
	    file.open(PLATFORM_INDEX, ios::in | ios::binary);
	    if (!file) {
            // Error opening file, return false.
	    	return false;
	    }
        
        // Initiate int, and read the current number of platforms in the list.
        int index;
        if (!file.read((char*) &index, sizeof(index))) {
            // File is uninitialized, index is 0.
            index = 0;
        }
        file.close();

        //WRITE NEW INDEX//
        // Initiate new PlatformNameStruct object.
        index++;
        PlatformNameStruct newPlatformName(index, newPlatform.getName());

        // Open the binary file to be written to.
	    file.open(PLATFORM_INDEX, ios::out | ios::binary);
	    if (!file) {
            // Error opening file, return false.
	    	return false;
	    }

        // Write the new number of platforms into the start of the data file.
        file.write((char*) &index, sizeof(index));
        file.close();

        //WRITE NEW PLATFORMNAMESTRUCT//
        // Open the binary file to be written to.
	    file.open(PLATFORM_NAME_LIST, ios::app | ios::binary);
	    if (!file) {
            // Error opening file, return false.
	    	return false;
	    }

        // Write the new PlatformNameStruct into the data file.
        file.write((char*) &newPlatformName, sizeof(PlatformNameStruct));
        file.close();

        //WRITE NEW PLATFORMSTRUCT//
        // Open the binary file to be written to.
	    file.open(PLATFORM_LIST, ios::app | ios::binary);
	    if (!file) {
            // Error opening file, return false.
	    	return false;
	    }

        // Write the new number PlatformStruct into the data file.
        file.write((char*) &newPlatform, sizeof(PlatformStruct));
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
    std::list<PlatformNameStruct*>* getPlatformNames() {
        //GET NUMBER OF PLATFORM NAMES//
        // Open the binary file to be read from.
	    fstream file;
	    file.open(PLATFORM_INDEX, ios::in | ios::binary);
	    if (!file) {
            // Error opening file, return nullptr.
	    	return nullptr;
	    }
        
        // Initiate int, and read the current number of platforms in the list.
        int num;
        if (!file.read((char*) &num, sizeof(num))) {
            // Error reading file, return nullptr.
            return nullptr;
        }
        file.close();

        //GET EVERY PLATFORM NAME, AND PUT THEM IN A LIST//
        // Open the binary file to be read from.
	    file.open(PLATFORM_NAME_LIST, ios::in | ios::binary);
	    if (!file) {
            // Error opening file, return nullptr.
	    	return nullptr;
	    }

        list<PlatformNameStruct*> *result = new list<PlatformNameStruct*>();

        // Loop through binary file, and read each PlatformNameStruct.
        for (int i = 0; i < num; i++) {
            PlatformNameStruct* curr = new PlatformNameStruct();

            // Seek to the location of the current PlatformNameStruct.
            file.seekg(sizeof(PlatformNameStruct) * i, std::ios::beg);

            // Read the current PlatformnameStruct from the binary file.
            if (!file.read((char*) curr, sizeof(PlatformNameStruct))) {
                // Error reading file, return nullptr.
                return nullptr;
            }

            // Add the current PlatformNameStruct to the list.
            result->push_back(curr);
        }
        file.close();

        return result;
    }

    // Returns the list of available GameNameStructs. The user 
    // is responsible for cleaning up when they are done with it.
    // Returns nullptr if an error occurs.
    std::list<GameNameStruct*>* getGameNames() {return nullptr;}

    // Returns the PlatformStruct associated with the given PlatformNameStruct.
    // User is responsible for cleanup when they're done with it.
    // If it does not exist in the database, or if another error occurs,
    // will return nullptr.
    PlatformStruct* getPlatform(PlatformNameStruct platform) {
        //GET INDEX AND NAME//
        int index = platform.getIndex();

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

        // Initiate blank PlatformNameStruct fields, read from the file onto it.
        char name[17], username[17], password[65], path[257];
        if (!file.read(name, NAME_SIZE)) {
            // Error reading file, return nullptr.
            return nullptr;
        }

        // Seek to the location of the username.
        file.seekg((sizeof(PlatformStruct) * (index - 1)) + NAME_SIZE, std::ios::beg);
        if (!file.read(username, USERNAME_SIZE)) {
            // Error reading file, return nullptr.
            return nullptr;
        }

        // Seek to the location of the password.
        file.seekg((sizeof(PlatformStruct) * (index - 1)) + NAME_SIZE + USERNAME_SIZE, std::ios::beg);
        if (!file.read(password, PASSWORD_SIZE)) {
            // Error reading file, return nullptr.
            return nullptr;
        }

        // Seek to the location of the path.
        file.seekg((sizeof(PlatformStruct) * (index - 1)) + NAME_SIZE + USERNAME_SIZE + PASSWORD_SIZE, std::ios::beg);
        if (!file.read(path, PATH_SIZE)) {
            // Error reading file, return nullptr.
            return nullptr;
        }
        file.close();

        // Create the resulting PlatformStruct with the variables from memory
        PlatformStruct* result = new PlatformStruct(name, username, password, path);

        return result;
    }

    // Returns the GameStruct associated with the given GameNameStruct.
    // User is responsible for cleanup when they're done with it.
    // If it does not exist in the database, or if another error occurs,
    // will return nullptr.
    GameStruct* getGame(GameNameStruct game) {return nullptr;}
}