// Kelby S. & Leonardo O.
// File to Launch Games


#include "gamelauncher.h"
using namespace std;


int main() {

    std::string full_path;
    std::cout << "Enter path: ";
    std::getline(std::cin, full_path);

    // make sure path is readable
    EnhancePath(full_path);
    if (full_path.length() == 0) {
        return EXIT_FAILURE;
    }

    // check valid path
    if (!checkPath(full_path)) {
        cout << "The path is not valid!";
        return EXIT_FAILURE;
    }

    // Create the process to launch game.
    launchGame(full_path);

    return 0;
}


void launchGame(std::string& path){
    HANDLE hProcess;
    HANDLE hThread;
    DWORD dwProcessID =0;
    DWORD dwThreadId =0;

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
    cout<<"GetProcessID ->"<<GetProcessId(processinfo.hProcess)<<endl;
    cout<<"GetThreadID _> ->"<<GetThreadId(processinfo.hThread)<<endl;

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


void EnhancePath(std::string& path) {
    path.erase(std::remove(path.begin(), path.end(), '\"'), path.end());
    if (path.length() > 4 && path.substr(path.length() - 4) == ".exe"){
        size_t i = 0;
        while ((i = path.find("\\", i)) != std::string::npos) {
            path.replace(i, 1, "/");
            i += 1;
        }
    } else {
        path = "";
    }
}