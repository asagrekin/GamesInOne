#ifndef _EXAMPLE_H_
#define _EXAMPLE_H_

using namespace std;

class PlatformNameStruct {
    public:
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

        int getIndex() {return index_;}

        char* getName() {return name_;}
    private:
        int index_;
        char name_[17];
};

#endif