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
#include <string>
#include <unordered_map>

namespace gamesDB{
    #define NAME_SIZE 17
    #define PATH_SIZE 257

    class dbObject {
        public:
            // Creates a new object instance.
            dbObject(const string &name, const string &path, const string &image_path) {
                // Set the ID to a hash of the game path.
                ID_ = std::hash<std::string>{}(path);

                // Copy name, path, and image path.
                strncpy(name_, name.c_str(), NAME_SIZE);
                strncpy(path_, path.c_str(), PATH_SIZE);
                strncpy(image_path_, image_path.c_str(), PATH_SIZE);
            }

            // Deletes the object instance.
            ~dbObject() {}

            int getID() {return ID_;} // Returns the ID.
            char* getName() {return name_;} // Returns the stored name.
            char* getPath() {return path_;} // Returns the stored name.
            char* getImagePath() {return image_path_;} // Returns the stored name.

            // FOR DATABASE USE ONLY.
            void decrementIndex() {index_--;} // Decrements the index.
        private:
            int ID_;
            char name_[NAME_SIZE], path_[PATH_SIZE], image_path_[PATH_SIZE];
    };
}
#endif