/**
 * This is an example use of the databse interface. Use for reference.
*/

#include <iostream>
#include <fstream>
#include <cstdlib>
#include <list>
#include "example.h"
#include "gamesDB.h"

using namespace std;

int main(int argc, char **argv) {
	//MANUALLY RESET THE DATABASE FILES. FOR DEMO PURPOSES ONLY. DON'T DO THIS!!!!//
	// Platform list
	fstream file;
	int index = 0;
    file.open("dbFiles/pltnmelst.dat", ios::out | ios::binary);
	if (!file) {
	    cout << "Error opening file" << endl;
		return EXIT_FAILURE;
	}
	file.write((char*) &index, sizeof(index));	
	file.close();

	// Game list
	file.open("dbFiles/gmenmelst.dat", ios::out | ios::binary);
	if (!file) {
	    cout << "Error opening file" << endl;
		return EXIT_FAILURE;
	}
	file.write((char*) &index, sizeof(index));
	file.close();



	// Create a new PlatformStruct
	string name, username, password, path;
	name = "Steam";
	username = "Asa";
	password = "password123";
	path = "lick/my/butthole";

	PlatformStruct platform(name.c_str(), username.c_str(), password.c_str(), path.c_str());

	// Make call to gamesDB interface to store the new platform.
	if (!gamesDB::addPlatform(platform)) {
		// Error saving the platform. Exit failure.
		cout << "There was an error while saving the platform. Exiting..." << endl;
		return EXIT_FAILURE;
	}

	// Add a second one for testing purposes.
	if (!gamesDB::addPlatform(platform)) {
		// Error saving the platform. Exit failure.
		cout << "There was an error while saving the platform. Exiting..." << endl;
		return EXIT_FAILURE;
	}

	// Make call to get the list of Platform names/indexes.
	list<PlatformNameStruct*> *platformsList = gamesDB::getPlatformNames();
	cout << "Current number of games: " << platformsList->size() << endl;
	PlatformNameStruct *platformName = platformsList->back();
	cout << "Current index: " << platformName->getIndex() << endl;
	cout << "Current name: " << platformName->getName() << endl;

	// Make call to retrieve the platform info from the database.
	PlatformStruct *fromMemory = gamesDB::getPlatform(*platformName);
	if (fromMemory == nullptr) {
		// Error retrieving the platform from memory.
		cout << "There was an error while retrieving the platform. Exiting..." << endl;
		delete platformsList;
		return EXIT_FAILURE;
	}

	// Print the contents of the platfrom saved to memory to the console to confirm its validity.
	cout << "Name from memory: " << fromMemory->getName() << endl;
	cout << "Username from memory: " << fromMemory->getUsername() << endl;
	cout << "Password from memory: " << fromMemory->getPassword() << endl;
	cout << "Path from memory: " << fromMemory->getPath() << endl;

	// Clean up the struct from memory. DO THIS EVERY TIME TO PREVENT DATA LEAKS.
	delete fromMemory;
	delete platformsList;

	//MANUALLY RESET THE DATABASE FILES. FOR DEMO PURPOSES ONLY. DON'T DO THIS!!!!//
	// Platform list
    file.open("dbFiles/pltnmelst.dat", ios::out | ios::binary);
	if (!file) {
	    cout << "Error opening file" << endl;
		return EXIT_FAILURE;
	}
	file.write((char*) &index, sizeof(index));	
	file.close();

	// Game list
	file.open("dbFiles/gmenmelst.dat", ios::out | ios::binary);
	if (!file) {
	    cout << "Error opening file" << endl;
		return EXIT_FAILURE;
	}
	file.write((char*) &index, sizeof(index));
	file.close();

	return EXIT_SUCCESS;
}