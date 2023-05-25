#include "gamelauncher.h"           // BackEnd Launcher
#include "../database/gamesDB.h"    // DataBase
#include "../database/dbObjects.h"  // DataBase Object
#include <gtest/gtest.h>            // Google Testing Suite

using namespace std;



//                             NOTES FOR TESTING
// This application heavily relies on file paths from one's local computer. These tests
// are catered to a windows device and are using pre-installed file paths such as
// that of Windows calculator and notepad. If testing does not result in up-to-standard
// results please refer to the following to fix any path issues that may arrise.
//
// The below executable and image paths will need to be change to rely on a local path.
//          4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, 17, 18, 19, 20, 21, 22
//
// Fixing these paths to match that of those in one's local files should fix any issues
// that may arise when using the Google Test suite.


// TEST # 1 : Enhance path holds expected behavior for different file types.
TEST(ExampleTests, EnhancePath_FileTypeTests) {
   // File Types
   string exe =  ".exe";
   string png =  ".png";
   string jpeg = ".jpeg";
   string jpg =  ".jpg";
   string ico =  ".ico";
   string random = ".random";

   // Paths
   string test = "testpath";
   string path1 = test + exe;
   string path2 = test + png;
   string path3 = test + jpeg;
   string path4 = test + jpg;
   string path5 = test + ico;
   string path6 = test + random;

   // Standard expected behaviors.
   launcher::EnhancePath(path1, ".exe");
   launcher::EnhancePath(path2, "image");
   launcher::EnhancePath(path3, "image");
   launcher::EnhancePath(path4, "image");
   launcher::EnhancePath(path5, "image");
   launcher::EnhancePath(path6, "image");

   EXPECT_EQ("testpath.exe",  path1);
   EXPECT_EQ("testpath.png",  path2);
   EXPECT_EQ("testpath.jpeg", path3);
   EXPECT_EQ("testpath.jpg",  path4);
   EXPECT_EQ("testpath.ico",  path5);
   EXPECT_EQ("", path6);

   // Test an .exe as image and image as .exe
   launcher::EnhancePath(path1, "image");
   launcher::EnhancePath(path2, ".exe");

   EXPECT_EQ("", path1);
   EXPECT_EQ("", path2);
}


// TEST # 2 : Enhance path holds expected behavior when fixing a path's slashes.
TEST(ExampleTests, EnhancePath_FixSlash) {
   // File Types
   string exe =  ".exe";
   string png =  ".png";
   string jpeg = ".jpeg";
   string jpg =  ".jpg";
   string ico =  ".ico";
   string random = ".random";

   // Paths - Testing
   string test = "test\\the\\path";
   string path1 = test + exe;
   string path2 = test + png;
   string path3 = test + jpeg;
   string path4 = test + jpg;
   string path5 = test + ico;
   string path6 = test + random;

   // Paths - Fixed
   string fixed = "test/the/path";
   string fixed1 = fixed + exe;
   string fixed2 = fixed + png;
   string fixed3 = fixed + jpeg;
   string fixed4 = fixed + jpg;
   string fixed5 = fixed + ico;

   // Standard expected behaviors.
   launcher::EnhancePath(path1, ".exe");
   launcher::EnhancePath(path2, "image");
   launcher::EnhancePath(path3, "image");
   launcher::EnhancePath(path4, "image");
   launcher::EnhancePath(path5, "image");
   launcher::EnhancePath(path6, "image");

   EXPECT_EQ(fixed1, path1);
   EXPECT_EQ(fixed2, path2);
   EXPECT_EQ(fixed3, path3);
   EXPECT_EQ(fixed4, path4);
   EXPECT_EQ(fixed5, path5);
   EXPECT_EQ("", path6);
}


// TEST # 3 : Enhance path handles bad inputs appropriately.
TEST(ExampleTests, EnhancePath_BadInputs) {
   // Testing Strings
   string exe = ".exe";
   string slashes = "\\";
   string svFile = ".sv";
   string forwardSlash = "//";
   string threeChars = "xxx";
   string test1 = threeChars + svFile;
   string test2 = slashes + exe;
   string test3 = forwardSlash + exe;

   launcher::EnhancePath(test1, ".exe");
   launcher::EnhancePath(exe,   ".exe");
   launcher::EnhancePath(test2, ".exe");
   launcher::EnhancePath(test3, ".exe");

   EXPECT_EQ("", test1);
   EXPECT_EQ("", exe);
   EXPECT_EQ("/.exe", test2);
   EXPECT_EQ("//.exe", test3);
}


// TEST # 4 : CheckPath correctly distinguishes valid paths.
TEST(ExampleTests, checkpath) {
   string dir = "C:/Windows/System32/notepad.exe";
   string wrongdir = "C:WindowsSystem32otepad.png";
   string random = "\\random.exe";

   EXPECT_EQ(TRUE, launcher::checkPath(dir));
   EXPECT_EQ(FALSE, launcher::checkPath(wrongdir));
   EXPECT_EQ(FALSE, launcher::checkPath(random));
}


// TEST # 5 : LaunchGame launches provided executables as intended.
TEST(ExampleTests, LaunchGameGood) {
   string dir = "C:/Windows/System32/notepad.exe";

   // Capture the standard output produced by MyMethod
   testing::internal::CaptureStdout();
   launcher::launchGame(dir);
   std::string output = testing::internal::GetCapturedStdout();

   // Compare the captured output with the expected output
   EXPECT_EQ(output, "Create Process Success\n");
}


// TEST # 6 : LaunchGame rejects invalid executables as intended.
TEST(ExampleTests, LaunchGameBad) {
   // Missing slashes in path so it should not launch
   string dir = "C:WindowsSystem32notepad.exe";

   // Capture the standard output produced by MyMethod
   testing::internal::CaptureStdout();
   launcher::launchGame(dir);
   std::string output = testing::internal::GetCapturedStdout();

   // Compare the captured output with the expected output
   EXPECT_EQ(output, "Create Process Failed\n");
}


// TEST # 7 : AddGame promptly interacts with the database to add a game.
TEST(ExampleTests, AddGame) {
   string game_name = "notepad";
   string game_path = "C:/Windows/System32/notepad.exe";
   string image_path = "../testing_files/png_Image.png";

   // Clear database and get the data before beginning.
   gamesDB::clearDB();
   launcher::get_data();
   // Add the game to the database and collect output message.
   string output = launcher::add(game_name, game_path, image_path);
   EXPECT_EQ(output, "success");
}


// TEST # 8 : AddGame rejects the addition due to bad game path.
TEST(ExampleTests, AddGameBadGamePath) {
   // Game path is now just lolz.
   string game_name = "notepad";
   string game_path = "lolz";
   string image_path = "C:/Users/kelby/OneDrive/Desktop/uw.jpg";

   // Clear database and get the data before beginning.
   gamesDB::clearDB();
   launcher::get_data();
   // Add the game to the database and collect output message.
   string output = launcher::add(game_name, game_path, image_path);
   EXPECT_EQ(output, "Not a valid .exe file!");
}


// TEST # 9 : AddGame rejects the addition due to invalid game path.
TEST(ExampleTests, AddGameInvalidGamePath) {
   // Game path is now not a valid local path.
   string game_name = "notepad";
   string game_path = "C:/Testing/Is/Not/Fun.exe";
   string image_path = "C:/Users/kelby/OneDrive/Desktop/uw.jpg";

   // Clear database and get the data before beginning.
   gamesDB::clearDB();
   launcher::get_data();
   // Add the game to the database and collect output message.
   string output = launcher::add(game_name, game_path, image_path);
   EXPECT_EQ(output, "The game path is not valid!");
}


// TEST # 10 : AddGame rejects the addition due to bad image path.
TEST(ExampleTests, AddGameBadImagePath) {
   // Image path is now just lolz.
   string game_name = "notepad";
   string game_path = "C:/Windows/System32/notepad.exe";
   string image_path = "lolz";

   // Clear database and get the data before beginning.
   gamesDB::clearDB();
   launcher::get_data();
   // Add the game to the database and collect output message.
   string output = launcher::add(game_name, game_path, image_path);
   EXPECT_EQ(output, "Not a valid .ico, png, or jpeg/jpg file!");
}


// TEST # 11 : AddGame rejects the addition due to invalid image path.
TEST(ExampleTests, AddGameInvalidImagePath) {
   // Image path is now not a valid local path.
   string game_name = "notepad";
   string game_path = "C:/Windows/System32/notepad.exe";
   string image_path = "C:/Testing/Is/Not/Fun.jpg";

   // Clear database and get the data before beginning.
   gamesDB::clearDB();
   launcher::get_data();
   // Add the game to the database and collect output message.
   string output = launcher::add(game_name, game_path, image_path);
   EXPECT_EQ(output, "The image path is not valid!");
}


// TEST # 12 : AddGame rejects the new add because it already exists in the database.
TEST(ExampleTests, AddGameAlreadyExists) {
   string game_name = "notepad";
   string game_path = "C:/Windows/System32/notepad.exe";
   string image_path = "../testing_files/jpg_Image.jpg";

   // Clear database and get the data before beginning.
   gamesDB::clearDB();
   launcher::get_data();
   // Add the game to the database and collect output message.
   launcher::add(game_name, game_path, image_path);
   string output = launcher::add(game_name, game_path, image_path);
   EXPECT_EQ(output, "this path already exists!");
}


// TEST # 13 : Delete Game succesfully deletes a game from the database.
TEST(ExampleTests, DeleteGame) {
   string game_name = "notepad";
   string game_path = "C:/Windows/System32/notepad.exe";
   string image_path = "../testing_files/jpg_Image.jpg";

   // Add a game before deleting
   gamesDB::clearDB();
   list<gamesDB::dbObject*>* games = launcher::get_data();
   launcher::add(game_name, game_path, image_path);

   // Aquire the id to use for the delete
   games = launcher::get_data();
   int id;
   list<gamesDB::dbObject*>::iterator it;
   for (it = games->begin(); it != games->end(); it++) {
      string game = (*it)->getName();
      if (game == "notepad") {
         id = (*it)->getID();
      }
   }

   // Delete the game with the selected id.
   string del_result = launcher::del(id);
   EXPECT_EQ(del_result, "success");
}


// TEST # 14 : Delete Game was not successful because the game was already deleted.
TEST(ExampleTests, DeleteGameBad) {
   string game_name = "notepad";
   string game_path = "C:/Windows/System32/notepad.exe";
   string image_path = "C:/Users/kelby/OneDrive/Desktop/uw.jpg";

   // Add a game
   gamesDB::clearDB();
   list<gamesDB::dbObject*>* games = launcher::get_data();
   launcher::add(game_name, game_path, image_path);

   // Aquire the id to use for the delete
   games = launcher::get_data();
   int id = 0;
   list<gamesDB::dbObject*>::iterator it;
   for (it = games->begin(); it != games->end(); it++) {
      string game = (*it)->getName();
      if (game == "notepad") {
         id = (*it)->getID();
      }
   }

   // Delete the game with the selected id twice to invoke error.
   launcher::del(id);
   string del_result = launcher::del(id);
   EXPECT_EQ(del_result, "game could not be deleted");
}


// TEST # 15 : Game List successfully lists added games.
TEST(ExampleTests, GameList) {
   string game_name = "notepad";
   string game_path = "C:/Windows/System32/notepad.exe";
   string image_path = "../testing_files/jpg_Image.jpg";

   string game_name_2 = "calculator";
   string game_path_2 = "C:/Windows/System32/calc.exe";

   // Add two games to use for the gamelist.
   gamesDB::clearDB();
   list<gamesDB::dbObject*>* games = launcher::get_data();
   launcher::add(game_name, game_path, image_path);
   launcher::add(game_name_2, game_path_2, image_path);

   // Get both game's id values from the database.
   games = launcher::get_data();
   int id, id2;
   list<gamesDB::dbObject*>::iterator it;
   for (it = games->begin(); it != games->end(); it++) {
      string game = (*it)->getName();
      if (game == "notepad") {
         id = (*it)->getID();
      }
      if (game == "calculator") {
         id2 = (*it)->getID();
      }
   }

   // Build our expected and invoke the displayed behavior from calling the method.
   string expected = "Name: notepad,  ID: " + to_string(id) + "\n" +
                     "Name: calculator,  ID: " + to_string(id2) + "\n";
   testing::internal::CaptureStdout();
   launcher::gameList();
   std::string output = testing::internal::GetCapturedStdout();

   EXPECT_EQ(output, expected);
}


// TEST # 16 : Game List successfully lists no games when the database is empty.
TEST(ExampleTests, GameListEmpty) {
   // Set up an empty games list.
   gamesDB::clearDB();
   list<gamesDB::dbObject*>* games = launcher::get_data();

   // Save the invoked behavior from calling gameList.
   testing::internal::CaptureStdout();
   launcher::gameList();
   std::string output = testing::internal::GetCapturedStdout();

   EXPECT_EQ(output, "");
}


// TEST # 17 : Game List successfully lists appropriate games after adds and deletes occured.
TEST(ExampleTests, GameListAddDeleteGame) {
   string game_name = "notepad";
   string game_path = "C:/Windows/System32/notepad.exe";
   string image_path = "../testing_files/jpg_Image.jpg";

   string game_name_2 = "calculator";
   string game_path_2 = "C:/Windows/System32/calc.exe";

   // Add two games to use for the gamelist.
   gamesDB::clearDB();
   list<gamesDB::dbObject*>* games = launcher::get_data();
   launcher::add(game_name, game_path, image_path);
   launcher::add(game_name_2, game_path_2, image_path);

   // Get both game's id values from the database.
   games = launcher::get_data();
   int id, id2;
   list<gamesDB::dbObject*>::iterator it;
   for (it = games->begin(); it != games->end(); it++) {
      string game = (*it)->getName();
      if (game == "notepad") {
         id = (*it)->getID();
      }
      if (game == "calculator") {
         id2 = (*it)->getID();
      }
   }

   // Delete the first game to invoke the database reaction.
   launcher::del(id);

   // Build our expected and invoke the displayed behavior from calling the method.
   string expected = "Name: calculator,  ID: " + to_string(id2) + "\n";
   testing::internal::CaptureStdout();
   launcher::gameList();
   std::string output = testing::internal::GetCapturedStdout();

   EXPECT_EQ(output, expected);
}


// TEST # 18 : Play executes the selected game from the database as expected.
TEST(ExampleTests, PlayGood) {
   string game_name = "notepad";
   string game_path = "C:/Windows/System32/notepad.exe";
   string image_path = "../testing_files/jpg_Image.jpg";

   // Setup and add a game to the database.
   gamesDB::clearDB();
   list<gamesDB::dbObject*>* games = launcher::get_data();
   launcher::add(game_name, game_path, image_path);

   // Get the id for the game added to the database.
   games = launcher::get_data();
   int id;
   list<gamesDB::dbObject*>::iterator it;
   for (it = games->begin(); it != games->end(); it++) {
      string game = (*it)->getName();
      if (game == "notepad") {
         id = (*it)->getID();
      }
   }

   // Collect the status of the play method and if true the play was a success.
   boolean output = launcher::play(id);
   EXPECT_TRUE(output);
}


// TEST # 19 : Play rejects the selected game as it does not exist in the database.
TEST(ExampleTests, PlayBad) {
   string game_name = "notepad";
   string game_path = "C:/Windows/System32/notepad.exe";
   string image_path = "C:/Users/kelby/OneDrive/Desktop/uw.jpg";
   int random_id = 123456;

   // Set up database and add a game to it.
   gamesDB::clearDB();
   list<gamesDB::dbObject*>* games = launcher::get_data();
   launcher::add(game_name, game_path, image_path);
   launcher::get_data();

   // Try launching an id that does not exist in the database.
   boolean output = launcher::play(random_id);
   EXPECT_FALSE(output);
}


// TEST # 20 : The call to get_data is succesful in intializing the database.
TEST(ExampleTests, GetData) {
   string game_name = "notepad";
   string game_path = "C:/Windows/System32/notepad.exe";
   string image_path = "C:/Users/kelby/OneDrive/Desktop/uw.jpg";

   // Set up the database and invoke succeed if the call was a success.
   gamesDB::clearDB();
   list<gamesDB::dbObject*>* games = launcher::get_data();
   launcher::add(game_name, game_path, image_path);
   games = launcher::get_data();
   SUCCEED()<< "Invokes succeed if successful";
}


// TEST # 21 : HasPath successfully finds the given game_path in the database.
TEST(ExampleTests, HasPathGood) {
   string game_name = "notepad";
   string game_path = "C:/Windows/System32/notepad.exe";
   string image_path = "../testing_files/jpg_Image.jpg";

   // Setup database and add a game to it.
   gamesDB::clearDB();
   launcher::get_data();
   launcher::add(game_name, game_path, image_path);

   // After adding game check that the database has the path for this game saved.
   boolean output = launcher::hasPath(game_path);
   EXPECT_TRUE(output);
}


// TEST # 22 : HasPath unsuccessfully finds the given game_path in the database.
TEST(ExampleTests, HasPathBad) {
   string game_name = "notepad";
   string game_path = "C:/Windows/System32/notepad.exe";
   string image_path = "C:/Users/kelby/OneDrive/Desktop/uw.jpg";
   string bad_name = "chrome";

   // Setup database and add a game to it.
   gamesDB::clearDB();
   launcher::get_data();
   launcher::add(game_name, game_path, image_path);

   // Check if the database has a path that does not exist to invoke bad behavior.
   boolean output = launcher::hasPath(bad_name);
   EXPECT_FALSE(output);
}