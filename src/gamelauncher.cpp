// Kelby S. & Leonardo O.
// 4/11/2023
#include <Windows.h>
#include <iostream>
#include <string>
#include <sys/stat.h>
#include <stdlib.h>
#include <fstream>
#include <algorithm>


using namespace std;

BOOL checkPath(std::string path) ;

void EnhancePath(std::string& path) ;

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


    // Don't really need
    HANDLE hProcess;
    HANDLE hThread;
    DWORD dwProcessID =0;
    DWORD dwThreadId =0;

    // Bare framework we need is lines 16-23 to complete what we want.
    STARTUPINFO startinfo;
	PROCESS_INFORMATION processinfo;
    ZeroMemory(&startinfo, sizeof(startinfo));
    ZeroMemory(&processinfo, sizeof(processinfo));

    char* path = &full_path[0];

	BOOL bScucces = CreateProcess(NULL, path,
			NULL, NULL, FALSE, 0, NULL, NULL, &startinfo, &processinfo);


    // Error handling
    if(bScucces == FALSE)
    {
        cout<<"Create Process Failed & Error No - "<<GetLastError()<<endl;
    }

    // We had success
    cout<<"Create Process Success"<<endl;

    // Terminal will help us track the proccess and thread
    cout<<"Process ID ->"<<processinfo.dwProcessId<<endl;
    cout<<"Thread ID ->"<<processinfo.dwThreadId<<endl;
    cout<<"GetProcessID ->"<<GetProcessId(processinfo.hProcess)<<endl;
    cout<<"GetThreadID _> ->"<<GetThreadId(processinfo.hThread)<<endl;

    // Wait for process to go down then closs when finished
    WaitForSingleObject(processinfo.hProcess, INFINITE);
    CloseHandle(processinfo.hThread);
    CloseHandle(processinfo.hProcess);

    // Instead of instantly finishing main this will hold until someone closes
    // the game then this will resume the tasks in this main.
    system("PAUSE");
    return 0;
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


// Validates game is an exe file and fixes escape characters in the path.
// Inputs: A string representing supposed game's path.
// Outputs: A validated .exe string for the games with fixed exit characters.
// EXIT_FAILURE: If the input string path is not a .exe file.
void EnhancePath(std::string& path) {
    path.erase(std::remove(path.begin(), path.end(), '\"'), path.end());
    if (path.substr(path.length() - 4) == ".exe"){
        size_t i = 0;
        while ((i = path.find("\\", i)) != std::string::npos) {
            path.replace(i, 1, "/");
            i += 1;
        }
    } else {
        path = "";
    }
}