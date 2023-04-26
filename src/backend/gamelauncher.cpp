// Kelby S. & Leonardo O.
// File to Launch Games


#include "gamelauncher.h"
using namespace std;


namespace launcher {

    void launchGame(string& path){
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
        //system("PAUSE");
    }


    BOOL checkPath(string dir) {
        ifstream file(dir);
        if (file.good()) {
            file.close();
            return true;
        } else {
            file.close();
            return false;
        }
    }


    void EnhancePath(string& path, string file_type) {
        path.erase(std::remove(path.begin(), path.end(), '\"'), path.end());
        if (path.length() > 4 && path.substr(path.length() - 4) == file_type){
            size_t i = 0;
            while ((i = path.find("\\", i)) != string::npos) {
                path.replace(i, 1, "/");
                i += 1;
            }
        } else {
            path = "";
        }
    }

    string add(string game_name, string game_path, string image_path) {
        // make sure path for game is readable
        EnhancePath(game_path, ".exe");
        if (game_path.length() == 0) {
            return "Not a valid .exe file!";
        }

        // check valid path for game
        if (!checkPath(game_path)) {
            return "The game path is not valid!";
        }

        // make sure path is readable
        EnhancePath(image_path, ".ico");
        if (image_path.length() == 0) {
            return "Not a valid .ico file!";
        }

        // check valid path
        if (!checkPath(image_path)) {
            return "The image path is not valid!";
        }

        gamesDB::dbObject* gameinfo = gamesDB::storeGame(game_name, game_path, image_path);
        if (gameinfo == nullptr) {
            return "unable to store " + game_name;
        }
        return "success";
    }

    BOOL play(string game_name) {
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
        delete games;
        if (!found) {
            return 0;
        }
        return 1;
    }

    void gameList() {
        list<gamesDB::dbObject*>* games = gamesDB::getGames();

        for (list<gamesDB::dbObject*>::iterator it = games->begin(); it != games->end(); it++) {
            cout << "Name: " << (*it)->getName() << ",  ID: " << (*it)->getIndex() << endl;
        }
    }

    void del() {
        // std::string game_name;
        // std::cout << "Enter game to delete: ";
        // std::getline(std::cin, game_name);
        // list<gamesDB::dbObject*>* games = gamesDB::getGames();
        // bool deleted = false;
        // for (list<gamesDB::dbObject*>::iterator it = games->begin(); it != games->end(); it++) {
        //     if (game_name == (*it)->getName()) {
        //         cout << (*it)->getName() << endl;
        //         delete *it;
        //         deleted = true;
        //         break;
        //     }
        // }
        // if (!deleted) {
        //     cout << game_name << " was not deleted" << endl;
        // }
    }
}