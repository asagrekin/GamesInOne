// This is an example of how to use the database.

#include <iostream>
#include <fstream>
#include <cstdlib>
#include <list>
#include "example.h"
#include "gamesDB.h"

using namespace std;

int main(int argc, char **argv) {
	// Create a new PlatformNameStruct and PlatformStruct
	string name, username, password, path;
	name = "Steam";
	username = "Asa";
	password = "password123";
	path = "lick/my/butthole";

	PlatformStruct platform(name.c_str(), username.c_str(), password.c_str(), path.c_str());
	PlatformNameStruct platformName(1, name.c_str());

	// Make call to gamesDB interface to store the new platform.
	if (!gamesDB::addPlatform(platform)) {
		// Error saving the platform. Exit failure.
		cout << "There was an error while saving the platform. Exiting..." << endl;
		return EXIT_FAILURE;
	}

	// Make call to retrieve the platform info from the database.
	PlatformStruct *fromMemory = gamesDB::getPlatform(platformName);
	if (fromMemory == nullptr) {
		// Error retrieving the platform from memory.
		cout << "There was an error while retrieving the platform. Exiting..." << endl;
		return EXIT_FAILURE;
	}

	// Print the contents of the platfrom saved to memory to the console to confirm its validity.
	cout << fromMemory->getName() << endl;
	cout << fromMemory->getUsername() << endl;
	cout << fromMemory->getPassword() << endl;
	cout << fromMemory->getPath() << endl;

	// Clean up the struct from memory. DO THIS EVERY TIME TO PREVENT DATA LEAKS.
	delete fromMemory;

	return EXIT_SUCCESS;
}