/**
 * This is an example use of the databse interface. Use for reference.
*/

#include <iostream>
#include <fstream>
#include <cstdlib>
#include <list>
#include "gamesDB.h"
#include "dbObjects.h"

using namespace std;

int main(int argc, char **argv) {
	// CLEAR THE DATABASE //
	if (!gamesDB::clearDB()) {
		// There was an error.
		cout << "There was an error clearing the database." << endl;
		return EXIT_FAILURE;
	}



	// GET THE CURRENT LIST OF GAMES //
	// It will be empty since we just cleared the database.
	list<gamesDB::dbObject*>* games = gamesDB::getGames();
	if (games == nullptr) {
		// There was an error.
		cout << "There was an error retrieving the list of games." << endl;
		return EXIT_FAILURE;
	}
	cout << "The current number of games in the database is: " << games->size() << endl << endl << endl;



	// SOFT ADD GAMES TO THE LIST //
	// The backend is responsible for 
	gamesDB::dbObject* game1 = new gamesDB::dbObject("Halo", "halo/path.exe", "halo/image/path.jpeg");
	gamesDB::dbObject* game2 = new gamesDB::dbObject("Fortnite", "fortnite/path.exe", "fornite/image/path.jpeg");
	gamesDB::dbObject* game3 = new gamesDB::dbObject("CoD", "cod/path.exe", "cod/image/path.jpeg");
	games->push_back(game1);
	games->push_back(game2);
	games->push_back(game3);



	// UPDATE THE LIST IN THE DATABASE //
	if (!gamesDB::storeGames(games)) {
		// There was an error.
		cout << "There was an error storing the games in the database." << endl;
		return EXIT_FAILURE;
	}

	// Cleaning up the list to prevent memory leaks
	delete games;
	delete game1;
	delete game2;
	delete game3;



	// PROVE THAT IT WAS STORED IN MEMORY (FOR DEMO PURPOSES ONLY) //
	// Retrieve the new list of games from the database.
	games = gamesDB::getGames();

	// Loop through the list, and print out the details.
	cout << "The current number of games in the database is: " << games->size() << endl;
	for (list<gamesDB::dbObject*>::iterator it = games->begin(); it != games->end(); ++it) {
		cout << (*it)->getID() << ": " << (*it)->getName() << ", " << (*it)->getPath()
			 << ", " << (*it)->getImagePath() << endl;
	}
	
	// Clean up the list again.
	for (list<gamesDB::dbObject*>::iterator it = games->begin(); it != games->end(); ++it) {
		delete *it;
	}
	delete games;



	return EXIT_SUCCESS;
}