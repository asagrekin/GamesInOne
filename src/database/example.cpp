// This is an example of how to use the database.

#include <iostream>
#include <fstream>
#include <cstdlib>

#define FILE_NAME "test.dat"

using namespace std;

// Class employee declaration. This is for demo purposes, so you can see what how an object will be stored.
class Employee {
private : 
	int 	empID;
	char 	empName[100] ;
	char 	designation[100];
	int 	ddj,mmj,yyj;
	int 	ddb,mmb,yyb;

public  :
	// Function to read employee details
	void readEmployee() {
		cout << "EMPLOYEE DETAILS" << endl;
		cout << "ENTER EMPLOYEE ID : ";
		cin >> empID;
		cin.ignore(1);
		cout << "ENTER  NAME OF THE EMPLOYEE : ";
		cin.getline(empName, 100);

		cout << "ENTER DESIGNATION : ";
		cin.getline(designation, 100);
		
		cout << "ENTER DATE OF JOIN:" << endl;
		cout << "DATE : "; cin >> ddj;
		cout << "MONTH: "; cin >> mmj;
		cout << "YEAR : "; cin >> yyj;
		
		cout << "ENTER DATE OF BIRTH:" << endl;
		cout << "DATE : "; cin >> ddb;
		cout << "MONTH: "; cin >> mmb;
		cout << "YEAR : "; cin >> yyb;
	}
    
	// Function to write employee details
	void displayEmployee(){
		cout << "EMPLOYEE ID: " << empID << endl
		 << "EMPLOYEE NAME: " << empName << endl
		 << "DESIGNATION: " << designation << endl
		 << "DATE OF JOIN: " << ddj << "/"<<mmj << "/" << yyj << endl
		 << "DATE OF BIRTH: " << ddb << "/" << mmb << "/" << yyb << endl;
	}
};

int main(int argc, char **argv) {
    // Instantiate and Employee and get details from user.
	Employee emp;
	emp.readEmployee();

    // Open the binary file to be written to.
	fstream file;
	file.open(FILE_NAME, ios::out | ios::binary);
	if (!file) {
		cout << "Error in creating file...\n";
		return EXIT_FAILURE;
	}

    // Write to the file, and close it.
    file.write((char*) &emp, sizeof(emp));
	file.close();
    cout << "Date saved into file the file.\n";
	
	// Open the file to be read from.
	file.open(FILE_NAME, ios::in | ios::binary);
	if (!file) {
		cout << "Error in opening file...\n";
		return EXIT_FAILURE;
	}
	
    // Read from the file.
	if (file.read((char*) &emp, sizeof(emp))) {
			cout << endl << endl;
			cout << "Data extracted from file..\n";
			// Write the detail to console.
			emp.displayEmployee();
	} else {
		cout << "Error in reading data from file...\n";
		return EXIT_FAILURE;
	}
	
    // Close the file again.
	file.close();
    return EXIT_SUCCESS;
}