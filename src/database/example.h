// These are example objects to be stored in the databse. These are not final,
// they are only here for testing and demonstration purposes.

#ifndef _EXAMPLE_H_
#define _EXAMPLE_H_

using namespace std;

// Object containing the name and index of a digital gaming platform.
class PlatformNameStruct {
    public:
        // Creates a new object instance.
        PlatformNameStruct(int index, char *name) : index_(index) {
            int i;
            for (i = 0; i < 16; i++) {
                if (name[i] == '\0') {
                    break;
                }
                name_[i] = name[i]; 
            }
            name_[i] = '\0';
        }

        // Destructs the instance.
        ~PlatformNameStruct() {}

        int getIndex() {return index_;} // Returns the index of the platform.
        char* getName() {return name_;} // Returns the stores name of the platform.
    private:
        int index_;
        char name_[17];
};

// Object containing the name and index of a game.
class GameNameStruct {
    public:
        // Creates a new object instance.
        GameNameStruct(int index, char *name) : index_(index) {
            int i;
            for (i = 0; i < 16; i++) {
                if (name[i] == '\0') {
                    break;
                }
                name_[i] = name[i]; 
            }
            name_[i] = '\0';
        }

        // Destructs the instance.
        ~GameNameStruct() {}

        int getIndex() {return index_;} // Returns the index of the game.
        char* getName() {return name_;} // Returns the stores name of the game.
    private:
        int index_;
        char name_[17];
};

// Object containing the information of a digital gaming platform.
class PlatformStruct {
    public:
        // Creates a new object instance with blank fields.
        PlatformStruct() {}

        // Creates a new object instance with data.
        PlatformStruct(char* name, char* username, char* password, char* path) {
            int i;
            for (i = 0; i < 16; i++) {
                if (name[i] == '\0') {
                    break;
                }
                name_[i] = name[i]; 
            }
            name_[i] = '\0';

            for (i = 0; i < 16; i++) {
                if (username[i] == '\0') {
                    break;
                }
                username_[i] = username[i]; 
            }
            username_[i] = '\0';

            for (i = 0; i < 64; i++) {
                if (password[i] == '\0') {
                    break;
                }
                password_[i] = password[i]; 
            }
            password_[i] = '\0';

            for (i = 0; i < 256; i++) {
                if (path[i] == '\0') {
                    break;
                }
                path_[i] = path[i]; 
            }
            path_[i] = '\0';
        }

        // Destructs the instance.
        ~PlatformStruct() {}

        char* getName() {return name_;} // Returns the platform name.
        char* getUsername() {return username_;} // Returns the username for the platform.
        char* getPassword() {return password_;} // Returns the password for the platform.
        char* getPath() {return path_;} // Returns the path for the platform.
    private:
        char name_[17], username_[17], password_[65], path_[257];
};

// Object containing the information of a game.
class GameStruct {
    public:
        // Creates a new object instance with blank fields.
        GameStruct() {}

        // Creates a new object instance.
        GameStruct(char* name, char* path) {
            int i;
            for (i = 0; i < 16; i++) {
                if (name[i] == '\0') {
                    break;
                }
                name_[i] = name[i]; 
            }
            name_[i] = '\0';

            for (i = 0; i < 256; i++) {
                if (path[i] == '\0') {
                    break;
                }
                path_[i] = path[i]; 
            }
            path_[i] = '\0';
        }

        // Destructs the instance.
        ~GameStruct() {}

        char* getName() {return name_;} // Returns the game's name.
        char* getPath() {return path_;} // Returns the path for the game.
    private:
        char name_[17], path_[257];
};
#endif