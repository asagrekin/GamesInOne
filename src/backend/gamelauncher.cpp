// Kelby S. & Leonardo O.
// File to Launch Games


#include "gamelauncher.h"
using namespace std;


int main() {

    std::string game_name;
    std::cout << "Enter game name: ";
    std::getline(std::cin, game_name);

    std::string game_path;
    std::cout << "Enter game path: ";
    std::getline(std::cin, game_path);

    // make sure path for game is readable
    EnhancePath(game_path, ".exe");
    if (game_path.length() == 0) {
        cout << "Not a valid .exe file!";
        return EXIT_FAILURE;
    }

    // check valid path for game
    if (!checkPath(game_path)) {
        cout << "The game path is not valid!";
        return EXIT_FAILURE;
    }

    std::string image_path;
    std::cout << "Enter image path: ";
    std::getline(std::cin, image_path);

    // make sure path is readable
    EnhancePath(image_path, ".ico");
    if (image_path.length() == 0) {
        cout << "Not a valid .ico file!";
        return EXIT_FAILURE;
    }

    // check valid path
    if (!checkPath(image_path)) {
        cout << "The image path is not valid!";
        return EXIT_FAILURE;
    }

    //   gamesDB::dbObject* game1 = gamesDB::storeGame(game_name, game_path, image_path);

    // cout << "Contents inserted game:" << endl << game1->getIndex() << endl << game1->getName() << endl
    //     << game1->getPath() << endl << game1->getImagePath() << endl << endl << endl;
    list<gamesDB::dbObject*>* games = gamesDB::getGames();
    for (list<gamesDB::dbObject*>::iterator it = games->begin(); it != games->end(); it++) {
		// The games can be accessed like so.
		cout << "Name: " << (*it)->getName() << endl << "Path: " << (*it)->getPath()
			 << endl << "Image path: " << (*it)->getImagePath() << endl << endl;
	}

    // Create the process to launch game.
    //launchGame(game_path);

    return 0;
}


void launchGame(std::string& path){
    // HANDLE hProcess;
    // HANDLE hThread;
    // DWORD dwProcessID =0;
    // DWORD dwThreadId =0;

    STARTUPINFO startinfo;
	PROCESS_INFORMATION processinfo;
    ZeroMemory(&startinfo, sizeof(startinfo));
    ZeroMemory(&processinfo, sizeof(processinfo));

    // Key components to creating process.
    char* game_path = &path[0];
	BOOL bScucces = CreateProcess(NULL, game_path,
			NULL, NULL, FALSE, 0, NULL, NULL, &startinfo, &processinfo);


    // Error handling
    if(bScucces == FALSE) {
        cout<<"Create Process Failed & Error No - "<<GetLastError()<<endl;
    }
    cout<<"Create Process Success"<<endl;

    // Terminal will help us track the proccess and thread
    cout<<"Process ID ->"<<processinfo.dwProcessId<<endl;
    cout<<"Thread ID ->"<<processinfo.dwThreadId<<endl;
    // cout<<"GetProcessID ->"<<GetProcessId(processinfo.hProcess)<<endl;
    // cout<<"GetThreadID _> ->"<<GetThreadId(processinfo.hThread)<<endl;

    // Wait for process to go down then close when finished
    WaitForSingleObject(processinfo.hProcess, INFINITE);
    CloseHandle(processinfo.hThread);
    CloseHandle(processinfo.hProcess);
    system("PAUSE");
}


BOOL checkPath(std::string dir) {
    std::ifstream file(dir);
    if (file.good()) {
        file.close();
        return true;
    } else {
        file.close();
        return false;
    }
}


void EnhancePath(std::string& path, std::string file_type) {
    path.erase(std::remove(path.begin(), path.end(), '\"'), path.end());
    if (path.length() > 4 && path.substr(path.length() - 4) == file_type){
        size_t i = 0;
        while ((i = path.find("\\", i)) != std::string::npos) {
            path.replace(i, 1, "/");
            i += 1;
        }
    } else {
        path = "";
    }
}