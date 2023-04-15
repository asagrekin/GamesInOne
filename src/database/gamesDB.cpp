/**
 * Implementation of the gamesDB namespace. Go to gamesDB.h for documentation.
*/

#include <fstream>
#include <iostream>
#include <list>
#include "gamesDB.h"

#define PLATFORM_NAME_LIST "pltnmelst.dat"
#define GAME_NAME_LIST     "gmenmelst.dat"
#define PLATFORM_LIST      "pltlst.dat"
#define GAME_LIST          "gmelst.dat"

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
}