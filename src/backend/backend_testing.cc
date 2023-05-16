#include "gamelauncher.h"           // BackEnd Launcher
#include "../database/gamesDB.h"    // DataBase
#include "../database/dbObjects.h"  // DataBase Object
#include <gtest/gtest.h>            // Google Testing Suite

using namespace std;


// int main(int argc, char** argv) {
//   testing::InitGoogleTest(&argc, argv);
//   launcher::get_data();
//   GTEST_FLAG_SET(ready_flag, "ready");
//   return RUN_ALL_TESTS();
// }



//   File Name,    Test Name
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



TEST(ExampleTests, EnhancePath_FixSlash) {
   // File Types
   string exe =  ".exe";
   string png =  ".png";
   string jpeg = ".jpeg";
   string jpg =  ".jpg";
   string ico =  ".ico";
   string random = ".random";

   // Paths - both test and fixed
   string test = "test\\the\\path";
   string path1 = test + exe;
   string path2 = test + png;
   string path3 = test + jpeg;
   string path4 = test + jpg;
   string path5 = test + ico;
   string path6 = test + random;

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



TEST(ExampleTests, checkpath) {
   // "C:\Windows\System32\notepad.exe"
   string dir = "C:/Windows/System32/notepad.exe";
   string wrongdir = "C:WindowsSystem32otepad.png";
   string random = "\\random.exe";

   EXPECT_EQ(TRUE, launcher::checkPath(dir));
   EXPECT_EQ(FALSE, launcher::checkPath(wrongdir));
   EXPECT_EQ(FALSE, launcher::checkPath(random));
}



TEST(ExampleTests, LaunchGameGood) {
   string dir = "C:/Windows/System32/notepad.exe";

   // Capture the standard output produced by MyMethod
   testing::internal::CaptureStdout();
   launcher::launchGame(dir);
   std::string output = testing::internal::GetCapturedStdout();

   // Compare the captured output with the expected output
   EXPECT_EQ(output, "Create Process Success\n");

}



TEST(ExampleTests, LaunchGameBad) {
   // Missing slashes so it wont launch
   string dir = "C:WindowsSystem32notepad.exe";

   // Capture the standard output produced by MyMethod
   testing::internal::CaptureStdout();
   launcher::launchGame(dir);
   std::string output = testing::internal::GetCapturedStdout();

   // Compare the captured output with the expected output
   EXPECT_EQ(output, "Create Process Failed\n");

}


TEST(ExampleTests, AddGame) {
   //GTEST_FLAG_SET(ready_flag, "ready");

   // string add(string game_name, string game_path, string image_path
   string game_name = "notepad";
   string game_path = "C:/Windows/System32/notepad.exe";
   string image_path = "C:/Users/kelby/OneDrive/Desktop/uw.jpg";
   //src\backend\uw.jpg

   // list<gamesDB::dbObject*>* gamelist = launcher::get_data();
   // for (list<gamesDB::dbObject*>::iterator it = gamelist->begin(); it != gamelist->end(); it++) {
   //    delete (*it);
   // }
   // delete gamelist;


   gamesDB::clearDB();
   launcher::get_data();
   string output = launcher::add(game_name, game_path, image_path);
   EXPECT_EQ(output, "success");
}


TEST(ExampleTests, DeleteGame) {
   string game_name = "notepad";
   string game_path = "C:/Windows/System32/notepad.exe";
   string image_path = "C:/Users/kelby/OneDrive/Desktop/uw.jpg";
   // Add a game
   gamesDB::clearDB();
   list<gamesDB::dbObject*>* games = launcher::get_data();
   launcher::add(game_name, game_path, image_path);

   games = launcher::get_data();
   int id;
   list<gamesDB::dbObject*>::iterator it;
   for (it = games->begin(); it != games->end(); it++) {
      string game = (*it)->getName();
      if (game == "notepad") {
         id = (*it)->getID();
      }
   }

    string del_result = launcher::del(id);
   EXPECT_EQ(del_result, "success");
}


TEST(ExampleTests, GameList) {
   string game_name = "notepad";
   string game_path = "C:/Windows/System32/notepad.exe";
   string image_path = "C:/Users/kelby/OneDrive/Desktop/uw.jpg";


   gamesDB::clearDB();
   list<gamesDB::dbObject*>* games = launcher::get_data();
   launcher::add(game_name, game_path, image_path);

   games = launcher::get_data();
   int id;
   list<gamesDB::dbObject*>::iterator it;
   for (it = games->begin(); it != games->end(); it++) {
      string game = (*it)->getName();
      if (game == "notepad") {
         id = (*it)->getID();
      }
   }
   string expected = "Name: notepad,  ID: " + to_string(id) + "\n";
   cout<<expected<<endl;
   testing::internal::CaptureStdout();
   launcher::gameList();
   std::string output = testing::internal::GetCapturedStdout();

   EXPECT_EQ(output, expected);
}


TEST(ExampleTests, Play) {
   string game_name = "notepad";
   string game_path = "C:/Windows/System32/notepad.exe";
   string image_path = "C:/Users/kelby/OneDrive/Desktop/uw.jpg";

   gamesDB::clearDB();
   list<gamesDB::dbObject*>* games = launcher::get_data();
   launcher::add(game_name, game_path, image_path);

   games = launcher::get_data();
   int id;
   list<gamesDB::dbObject*>::iterator it;
   for (it = games->begin(); it != games->end(); it++) {
      string game = (*it)->getName();
      if (game == "notepad") {
         id = (*it)->getID();
      }
   }

   boolean output = launcher::play(id);
   EXPECT_EQ(output, true);
}

TEST(ExampleTests, GetData) {
   string game_name = "notepad";
   string game_path = "C:/Windows/System32/notepad.exe";
   string image_path = "C:/Users/kelby/OneDrive/Desktop/uw.jpg";

   gamesDB::clearDB();
   list<gamesDB::dbObject*>* games = launcher::get_data();
   launcher::add(game_name, game_path, image_path);
   games = launcher::get_data();
   SUCCEED()<< "Invokes succeed if successful";
}


TEST(ExampleTests, HasPath) {
   string game_name = "notepad";
   string game_path = "C:/Windows/System32/notepad.exe";
   string image_path = "C:/Users/kelby/OneDrive/Desktop/uw.jpg";

   gamesDB::clearDB();
   launcher::get_data();
   launcher::add(game_name, game_path, image_path);

   boolean output = launcher::hasPath(game_path);
   cout<<output<<endl;
   EXPECT_TRUE(output);

}
