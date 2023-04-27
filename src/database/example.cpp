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
	// FOR DEMO PURPOSES ONLY. DON'T DO THIS //
	// Reset the index file.
	fstream file;
    file.open("dbFiles/ind.dat", ios::out | ios::binary);
	if (!file) {
	    cout << "Error opening file" << endl;
		return EXIT_FAILURE;
	}
	file.close();
	// Reset the games list file.
    file.open("dbFiles/lst.dat", ios::out | ios::binary);
	if (!file) {
	    cout << "Error opening file" << endl;
		return EXIT_FAILURE;
	}
	file.close();

	// ADD GAMES TO THE DATABASE //
	// Make call to gamesDB interdace to store a new game, and keep store the resulting object.
	gamesDB::dbObject* game1 = gamesDB::storeGame("Game1", "this/is/game1.exe", "game1_pic/ture.pdf");
	if (game1 == nullptr) {
		// There was an error storing the game in the database if nullptr is returned.
		cout << "There was an error storing the first game in the database." << endl;
		return EXIT_FAILURE;
	}

	// Store multiple other games in the database.
	gamesDB::dbObject* game2 = gamesDB::storeGame("Game2", "this_is/game2", "game2/pic_ture.pdf");
	gamesDB::dbObject* game3 = gamesDB::storeGame("Game3", "this/is_game3.exe", "game3/picture.pdf");
	gamesDB::dbObject* game4 = gamesDB::storeGame("Game4", "this_is_game4.exe", "game4_picture.pdf");

	if (game2 == nullptr) {
		// There was an error storing the game in the database if nullptr is returned.
		cout << "There was an error storing the second game in the database." << endl;
		return EXIT_FAILURE;
	} else if (game3 == nullptr) {
		// There was an error storing the game in the database if nullptr is returned.
		cout << "There was an error storing the third game in the database." << endl;
		return EXIT_FAILURE;
	} else if (game4 == nullptr) {
		// There was an error storing the game in the database if nullptr is returned.
		cout << "There was an error storing the fourth game in the database." << endl;
		return EXIT_FAILURE;
	}

	//********** get a copy for later use **********//
	gamesDB::dbObject temp = *game2;

	// Clean up the dbObjects that were returned to prevent memory leaks (except game2, we'll use that later).
	delete game1;
	delete game2;
	delete game3;
	delete game4;



	// RETRIEVE GAMES FROM THE DATABSE //
	// Make the call to get the list of games stored in the database.
	list<gamesDB::dbObject*>* games = gamesDB::getGames();
	if (games == nullptr) {
		// If the resulting list is equal to nullptr, an error occured.
		cout << "There was an error retrieving the list of games from the database." << endl;
		return EXIT_FAILURE;
	}

	// List the information that was stored in memory for all of the games.
	for (list<gamesDB::dbObject*>::iterator it = games->begin(); it != games->end(); it++) {
		// The games can be accessed like so.
		cout << "Name: " << (*it)->getName() << endl << "Path: " << (*it)->getPath()
			 << endl << "Image path: " << (*it)->getImagePath() << endl << endl;
	}

	// Clean up the list to prevent data leaks.
	for (list<gamesDB::dbObject*>::iterator it = games->begin(); it != games->end(); it++) {
		// Delete the individual games in the list.
		delete *it;
	}
	// Delete the list itself
	delete games;
	cout << endl << endl << endl;



	// DELETE A GAME //
	// Remove game 2 from the database, using the object we copied earlier.
	games = gamesDB::removeGame(&temp);

	// List the information of the remaining games.
	for (list<gamesDB::dbObject*>::iterator it = games->begin(); it != games->end(); it++) {
		// The games can be accessed like so.
		cout << "Name: " << (*it)->getName() << endl << "Path: " << (*it)->getPath()
			 << endl << "Image path: " << (*it)->getImagePath() << endl << endl;
	}

	// Clean up the list to prevent data leaks.
	for (list<gamesDB::dbObject*>::iterator it = games->begin(); it != games->end(); it++) {
		// Delete the individual games in the list.
		delete *it;
	}
	// Delete the list itself
	delete games;
	cout << endl << endl << endl;



	// DELETE A SECOND GAME USING INDEX //
	// Make the call to remove the second game using index.
	games = gamesDB::removeGame(2);
	
	// List the information of the remaining games.
	for (list<gamesDB::dbObject*>::iterator it = games->begin(); it != games->end(); it++) {
		// The games can be accessed like so.
		cout << "Name: " << (*it)->getName() << endl << "Path: " << (*it)->getPath()
			 << endl << "Image path: " << (*it)->getImagePath() << endl << endl;
	}

	// Clean up the list to prevent data leaks.
	for (list<gamesDB::dbObject*>::iterator it = games->begin(); it != games->end(); it++) {
		// Delete the individual games in the list.
		delete *it;
	}
	// Delete the list itself
	delete games;



	// FOR DEMO PURPOSES ONLY. DON'T DO THIS //
	// Reset the index file.
	// fstream file;
    file.open("dbFiles/ind.dat", ios::out | ios::binary);
	if (!file) {
	    cout << "Error opening file" << endl;
		return EXIT_FAILURE;
	}
	file.close();
	// Reset the games list file.
    file.open("dbFiles/lst.dat", ios::out | ios::binary);
	if (!file) {
	    cout << "Error opening file" << endl;
		return EXIT_FAILURE;
	}
	file.close();



	return EXIT_SUCCESS;
}