/**
 * This is the header file containing the objects to be used in for the databse interface.
 * Objects contain necessary information for backend.
 * Types:
 *  Index objects contain the name and index of the object in the database.
 *  Game objects contain the information necessary for backend operations.
*/

#ifndef _DBOBJECTS_H_
#define _DBOBJECTS_H_

#include <cstring>

namespace gamesDB{
    #define NAME_SIZE 17
    #define PATH_SIZE 257

    class dbObject {
        public:
            // Creates an empty object instance.
            dbObject() : index_(0) {}

            // Creates a new object instance.
            dbObject(int index, const char* name, const char* path, const char* image_path) : index_(index) {
                int i;
                // Copy name, path, and image path.
                strncpy(name_, name, NAME_SIZE);
                strncpy(path_, path, PATH_SIZE);
                strncpy(image_path_, image_path, PATH_SIZE);
            }

            // Deletes the object instance.
            ~dbObject() {}

            int getIndex() {return index_;} // Returns the index.
            char* getName() {return name_;} // Returns the stored name.
            char* getPath() {return path_;} // Returns the stored name.
            char* getImagePath() {return image_path_;} // Returns the stored name.
        private:
            int index_;
            char name_[NAME_SIZE], path_[PATH_SIZE], image_path_[PATH_SIZE];
    };
}
#endif