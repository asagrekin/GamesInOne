
// How to use launcher
#include <string>

using namespace std;

#include "gamelauncher.h"


int main() {
    // gamesDB::clearDB();
    // load the data when opening app
    list<gamesDB::dbObject*>* games = launcher::get_data();
    // front end needs to extract the game name, path, and image, ID
    list<gamesDB::dbObject*>::iterator it;
    for (it = games->begin(); it != games->end(); it++) {
        cout << "Name: " << (*it)->getName() << ",  Path: " << (*it)->getPath() << ",    Image: " 
        << (*it)->getImagePath() << ",  ID: " << (*it)->getID() << endl;
    }
    // how to add 
    string result = launcher::add("muck1", "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Muck\\Muck.exe", 
    "C:\\Program Files (x86)\\Steam\\steam\\games\\goose.ico");
    // checks if the item was added correctly
    if (result != "success") {
        // (frontend) check launcher::add for types of errors
        cout << result << endl;
        return EXIT_FAILURE;
    }

    // string icoResult = launcher::add("game1", "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Muck\\Muck.exe", 
    // "C:\\Program Files (x86)\\Steam\\steam\\games\\goose.ico");
    // // checks if the item was added correctly
    // if (result != "success") {
    //     // (frontend) check launcher::add for types of errors
    //     cout << result << endl;
    //     return EXIT_FAILURE;
    // }

    string pngResult = launcher::add("game2", "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Crab Game\\Crab Game.exe", 
    "C:\\Users\\qazml\\Downloads\\jpeg image.jpg");
    // checks if the item was added correctly
    if (result != "success") {
        // (frontend) check launcher::add for types of errors
        cout << result << endl;
        return EXIT_FAILURE;
    }

    string jpgResult = launcher::add("game3", "C:\\Program Files (x86)\\Steam\\steam.exe",
    "C:\\Program Files (x86)\\Steam\\steam\\games\\goose.ico");
    // checks if the item was added correctly
    if (result != "success") {
        // (frontend) check launcher::add for types of errors
        cout << result << endl;
        return EXIT_FAILURE;
    }

    // get the current list of games
    cout << endl;
    launcher::gameList();
    cout << endl;
    // find some id
    games = launcher::get_data();
    int id;
    for (it = games->begin(); it != games->end(); it++) {
        string game = (*it)->getName();
        if (game == "game2") {
            id = (*it)->getID();
        }
    }

    // how to launch
    if (!launcher::play(id)) {
        cout << "this game does not exist" << endl;
        return EXIT_FAILURE;
    }

    // delete game
    string del_result = launcher::del(id);
    if (del_result != "success") {
        cout << del_result << endl;
        return EXIT_FAILURE;
    }

    // print out game
    launcher::gameList();
    // gamesDB::clearDB();
    return 0;
}