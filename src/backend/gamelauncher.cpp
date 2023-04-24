// Kelby S. & Leonardo O.
// File to Launch Games


#include "gamelauncher.h"
using namespace std;


int main() {

    std::string task;
    std::cout << "Enter add, delete, play, or list: ";
    std::getline(std::cin, task);

    if (task == "add") {
        add();
    } else if (task == "delete") {
        del();
    } else if (task == "play") {
        play();
    } else if (task == "list") {
        gameList();
    } else {
        cout << "task not recognized" << endl;
    }

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

bool add() {
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
        return 0;
    }

    // check valid path for game
    if (!checkPath(game_path)) {
        cout << "The game path is not valid!";
        return 0;
    }

    std::string image_path;
    std::cout << "Enter image path: ";
    std::getline(std::cin, image_path);

    // make sure path is readable
    EnhancePath(image_path, ".ico");
    if (image_path.length() == 0) {
        cout << "Not a valid .ico file!";
        return 0;
    }

    // check valid path
    if (!checkPath(image_path)) {
        cout << "The image path is not valid!";
        return 0;
    }

    gamesDB::storeGame(game_name, game_path, image_path);
    return 1;
}

void play() {
    std::string game_name;
    std::cout << "Enter game to play: ";
    std::getline(std::cin, game_name);
    bool found = false;

    list<gamesDB::dbObject*>* games = gamesDB::getGames();

    for (list<gamesDB::dbObject*>::iterator it = games->begin(); it != games->end(); it++) {
        if (game_name == (*it)->getName()) {
            string path = (*it)->getPath();
            launchGame(path);
            found = true;
            break;
        }
    }
    if (!found) {
        cout << "game not found" << endl;
    }
}

void gameList() {
    list<gamesDB::dbObject*>* games = gamesDB::getGames();
    for (list<gamesDB::dbObject*>::iterator it = games->begin(); it != games->end(); it++) {
        cout << "Name: " << (*it)->getName() << endl;
    }
}

void del() {
    std::string game_name;
    std::cout << "Enter game to delete: ";
    std::getline(std::cin, game_name);
    list<gamesDB::dbObject*>* games = gamesDB::getGames();
    bool deleted = false;
    for (list<gamesDB::dbObject*>::iterator it = games->begin(); it != games->end(); it++) {
        if (game_name == (*it)->getName()) {
            cout << (*it)->getName() << endl;
            delete *it;
            deleted = true;
            break;
        }
    }
    if (!deleted) {
        cout << game_name << " was not deleted" << endl;
    }
}