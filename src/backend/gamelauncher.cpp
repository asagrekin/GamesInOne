// Kelby S. & Leonardo O.
// File to Launch Games

#include "pch.h"
#include "gamelauncher.h"
using namespace std;


namespace launcher {

    static list<gamesDB::dbObject*>* current_games;

    list<gamesDB::dbObject*>* get_data(){
        current_games = gamesDB::getGames();
        list<gamesDB::dbObject*>* current_games2 = new list<gamesDB::dbObject*>(*current_games);
        return current_games2;
    }

    void launchGame(string& path){
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
        if (path.length() > 4) {
            if ((file_type == ".exe" && path.substr(path.length() - 4) == ".exe")
                || (path.substr(path.length() - 4) == ".png" || path.substr(path.length() - 4) == ".ico"   
                || path.substr(path.length() - 4) == ".jpg" || path.substr(path.length() - 5) == ".jpeg")) {
                size_t i = 0;
                while ((i = path.find("\\", i)) != string::npos) {
                    path.replace(i, 1, "/");
                    i += 1;
                }
            } else {
                path = "";
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
        EnhancePath(image_path, "images");
        if (image_path.length() == 0) {
            return "Not a valid .ico, png, or jpeg/jpg file!";
        }

        // check valid path
        if (!checkPath(image_path)) {
            return "The image path is not valid!";
        }

        if (hasPath(game_path)) {
            return "this path already exists!";
        }

        gamesDB::dbObject* game = new gamesDB::dbObject(game_name, game_path, image_path);
        current_games->push_back(game);

        if (!gamesDB::storeGames(current_games)) {
	    	return "There was an error storing the games in the database.";
	    }
        return "success";
    }

    BOOL play(int id) {
        bool found = false;
        for (list<gamesDB::dbObject*>::iterator it = current_games->begin(); it != current_games->end(); it++) {
            if (id == (*it)->getID()) {
                string path = (*it)->getPath();
                launchGame(path);
                found = true;
                break;
            }
        }
        if (!found) {
            return 0;
        }
        return 1;
    }

    void gameList() {
        for (list<gamesDB::dbObject*>::iterator it = current_games->begin(); it != current_games->end(); it++) {
            cout << "Name: " << (*it)->getName() << ",  ID: " << (*it)->getID() << endl;
        }
    }

    string del(int id) {
        bool deleted = false;
        for (list<gamesDB::dbObject*>::iterator it = current_games->begin(); it != current_games->end(); it++) {
            if (id == (*it)->getID()) {
                it = current_games->erase(it);
                deleted = true;
                break;
            }
        }
        if (!deleted) {
            return "game could not be deleted";
        }
        gamesDB::clearDB();
        if (!gamesDB::storeGames(current_games)) {
	    	return "There was an error storing the games in the database.";
	    }
        return "success";
    }

    bool hasPath(string path) {
        for (list<gamesDB::dbObject*>::iterator it = current_games->begin(); it != current_games->end(); it++) {
            string check_path = (*it)->getPath();
            if ( check_path == path) {
                return true;
            }
        }
        return false;
    } 
}

