/**
 * This is the header file containing the objects to be used in for the databse interface.
 * Objects contain necessary information for backend.
 * Types:
 *  Index objects contain the name and index of the object in the database.
 *  Game objects contain the information necessary for backend operations.
*/

#ifndef _DBOBJECTS_H_
#define _DBOBJECTS_H_

namespace gamesDB{
    class dbObject {
        public:
            // Creates an empty object instance.
            dbObject() : index_(0) {}

            // Creates a new object instance.
            dbObject(int index, char* name) : index_(index) {
                int i;
                for (i = 0; i < 16; i++) {
                    if (name[i] == '\0') {
                        break;
                    }
                    name_[i] = name[i]; 
                }
                name_[i] = '\0';
            }

            // Deletes the object instance.
            ~dbObject() {}

            int getIndex() {return index_;} // Returns the index.
            char* getName() {return name_;} // Returns the stored name.
        private:
            int index_;
            char name_[17], path_[257], image_path_[257];
    };
}
#endif