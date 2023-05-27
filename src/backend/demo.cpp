
// How to use launcher
#include <string>
#include <map>

using namespace std;

#include "gamelauncher.h"


int main() {
    // clear the database
    gamesDB::clearDB();
    // get the current data stored in the database even if its empty to initialize the list of dbObjects
    list<gamesDB::dbObject*>* games = launcher::get_data();
    // how to add, here we are using notepad and an image located in backend/testing_files
    string result = launcher::add("notepad", "C:\\Windows\\notepad.exe", "testing_files/jpeg_Image.jpeg");
    
    // checks if the item was added correctly, which should be successful
    if (result != "success") {
        // produces different outputs depending on the error
        cout << result << endl;
    }

    // adding the same executable
    result = launcher::add("notepad", "C:\\Windows\\notepad.exe", "testing_files/jpeg_Image.jpeg");
    // checks if the item was added correctly
    if (result != "success") {
        // same executable error
        cout << result << endl;
    }

    // adding incorrect executable path
    result = launcher::add("file explorer", "C:\\Window\\explorer.exe", "testing_files/jpg_Image.jpg");
    // checks if the item was added correctly
    if (result != "success") {
        // invalid executable path
        cout << result << endl;
    }

    // adding incorrect image path
    result = launcher::add("file explorer", "C:\\Windows\\explorer.exe", "testingfiles/jpg_Image.jpg");
    // checks if the item was added correctly
    if (result != "success") {
        // invalid image path
        cout << result << endl;
    }

    // store file explorer
    result = launcher::add("file explorer", "C:\\Windows\\explorer.exe", "testing_files/jpg_Image.jpg");
    // checks if the item was added correctly
    if (result != "success") {
        cout << result << endl;
    }

    // store calculator
    result = launcher::add("calculator",  "C:\\Windows\\System32\\calc.exe", "testing_files/png_Image.png");
    // checks if the item was added correctly
    if (result != "success") {
        cout << result << endl;
    }

    // store wordPad
    result = launcher::add("word pad",  "C:\\Windows\\write.exe", "testing_files/jpeg_Image.jpeg");
    // checks if the item was added correctly
    if (result != "success") {
        cout << result << endl;
    }

    // reload the data stored in the database
    games = launcher::get_data();
    // store game name and ID
    map<string, int> map;
    // show the game name, path, image, and ID. Store the name and id in map.
    list<gamesDB::dbObject*>::iterator it;
    for (it = games->begin(); it != games->end(); it++) {
        cout << "Name: " << (*it)->getName() << ",    Path: " << (*it)->getPath() << ",   Image: " 
        << (*it)->getImagePath() << ",    ID: " << (*it)->getID() << endl;
        map[(*it)->getName()] = (*it)->getID();
    }

    // launch notepad
    if (!launcher::play(map["notepad"])) {
        cout << "this game does not exist" << endl;
    }

    // launch file explorer
    if (!launcher::play(map["file explorer"])) {
        cout << "this game does not exist" << endl;
    }

    // launch calculator
    if (!launcher::play(map["calculator"])) {
        cout << "this game does not exist" << endl;
    }

    // launch word pad
    if (!launcher::play(map["word pad"])) {
        cout << "this game does not exist" << endl;
    }

    // launch invalid id
    if (!launcher::play(1)) {
        cout << "this game does not exist" << endl;
    }

    // delete an executable, calculator
    string del_result = launcher::del(map["calculator"]);
    if (del_result != "success") {
        cout << del_result << endl;
    }

    // reload the data stored in the database
    games = launcher::get_data();
    // store game name and ID
    map.clear();
    // show the current game name, path, image, and ID. reload map
    for (it = games->begin(); it != games->end(); it++) {
        cout << "Name: " << (*it)->getName() << ",    Path: " << (*it)->getPath() << ",   Image: " 
        << (*it)->getImagePath() << ",    ID: " << (*it)->getID() << endl;
        map[(*it)->getName()] = (*it)->getID();
    }

    // try to launch the deleted calculator
    if (!launcher::play(map["calculator"])) {
        cout << "this game does not exist" << endl;
    }

    // try to delete the deleted calculator
    del_result = launcher::del(map["calculator"]);
    if (del_result != "success") {
        cout << del_result << endl;
    }

    // add the deleted executable again
    result = launcher::add("calculator",  "C:\\Windows\\System32\\calc.exe", "testing_files/png_Image.png");
    // checks if the item was added correctly
    if (result != "success") {
        cout << result << endl;
    }

    // reload the data stored in the database
    games = launcher::get_data();
    // store game name and ID
    map.clear();
    // show the current game name, path, image, and ID. reload map
    for (it = games->begin(); it != games->end(); it++) {
        cout << "Name: " << (*it)->getName() << ",    Path: " << (*it)->getPath() << ",   Image: " 
        << (*it)->getImagePath() << ",    ID: " << (*it)->getID() << endl;
        map[(*it)->getName()] = (*it)->getID();
    }

    // launch calculator
    if (!launcher::play(map["calculator"])) {
        cout << "this game does not exist" << endl;
    }
    return 0;
}