
#include <string>

using namespace std;

#include "gamelauncher.h"

int main() {
    
    // string result =  launcher::add("epic game", "C:\\Program Files\\Epic Games\\NeverAlone\\NeverAlone.exe", 
    //  "C:\\Program Files (x86)\\Steam\\steam\\games\\grab_game.ico");
    // if (result != "success") {
    //     cout << result << endl;
    //     return EXIT_FAILURE;
    // }

    launcher::gameList();
    if (!launcher::play("game 4")) {
        cout << "could not open game or game not found!!";
    }
    if (!launcher::play("game 4")) {
        cout << "could not open game or game not found!!";
    }
    return 0;
}