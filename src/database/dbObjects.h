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
            // Creates an empty object instance.
            dbObject() : ID_(0) {}

            // Creates a new object instance.
            dbObject(const std::string &name, const std::string &path, const std::string &image_path) {
                // Set the ID to a hash of the game path.
                std::hash<std::string> hasher;
                ID_ = hasher(path);

               // Copy name, path, and image path.
                strncpy_s(name_, name.c_str(), NAME_SIZE);
                strncpy_s(path_, path.c_str(), PATH_SIZE);
                strncpy_s(image_path_, image_path.c_str(), PATH_SIZE);
                // strncpy(name_, name.c_str(), NAME_SIZE);
                //                 name_[NAME_SIZE - 1] = '\0';
                //                 strncpy(path_, path.c_str(), PATH_SIZE);
                //                 path_[PATH_SIZE - 1] = '\0';
                //                 strncpy(image_path_, image_path.c_str(), PATH_SIZE);
                //                 image_path_[PATH_SIZE - 1] = '\0';

                //             }

            // Deletes the object instance.
            ~dbObject() {}

            int getID() {return ID_;} // Returns the ID.
            char* getName() {return name_;} // Returns the stored name.
            char* getPath() {return path_;} // Returns the stored name.
            char* getImagePath() {return image_path_;} // Returns the stored name.
        private:
            size_t ID_;
            char name_[NAME_SIZE], path_[PATH_SIZE], image_path_[PATH_SIZE];
    };
}
#endif