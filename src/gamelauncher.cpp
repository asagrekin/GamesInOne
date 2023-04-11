// Kelby S. & Leonardo O.
// 4/11/2023
#include<Windows.h>
#include<iostream>
using namespace std;


int main()
{
    // Shell option
    // ShellExecute(NULL, TEXT("open"), TEXT("C:\\Windows\\notepad.exe"), NULL, NULL, SW_SHOWDEFAULT);

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

	BOOL bScucces = CreateProcess(TEXT("C:\\Windows\\notepad.exe"), NULL,
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