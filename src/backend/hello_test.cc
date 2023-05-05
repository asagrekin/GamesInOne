#include "gamelauncher.h"   // BackEnd Launcher
#include "gamesDB.h"        // DataBase
#include "dbObjects.h"      // DataBase Object

#include <gtest/gtest.h>

using namespace std;


// // Demonstrate some basic assertions.
// TEST(HelloTest, BasicAssertions) {
//   // Expect two strings not to be equal.
//   EXPECT_STRNE("hello", "world");
//   // Expect equality.
//   EXPECT_EQ(7 * 6, 42);
// }




// File Name, Test Name
TEST(ExampleTests, EnhancePath_FileTypeTests) {
   string exe = ".exe";
   string png = ".png";
   string jpeg = ".jpeg";
   string jpg = ".jpg";
   string ico = ".ico";
   string random = ".whatever";

   string test = "testpath";
   string path1 = test + exe;
   string path2 = test + png;
   string path3 = test + jpeg;
   string path4 = test + jpg;
   string path5 = test + ico;
   string path6 = test + random;


   launcher::EnhancePath(path1, exe);
   launcher::EnhancePath(path2, "image");
   launcher::EnhancePath(path3, "image");
   launcher::EnhancePath(path4, "image");
   launcher::EnhancePath(path5, "image");
   launcher::EnhancePath(path6, random);
   EXPECT_EQ("testpath.exe", path1);
   EXPECT_EQ("testpath.png", path2);
   EXPECT_EQ("testpath.jpeg", path3);
   EXPECT_EQ("testpath.jpg", path4);
   EXPECT_EQ("testpath.ico", path5);
   EXPECT_EQ("", path6);
}


TEST(ExampleTests, EnhancePath_FixSlash) {
   string exe = ".exe";
   string png = ".png";
   string jpeg = ".jpeg";
   string jpg = ".jpg";
   string ico = ".ico";
   string random = ".whatever";

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

   launcher::EnhancePath(path1, exe);
   launcher::EnhancePath(path2, "image");
   launcher::EnhancePath(path3, "image");
   launcher::EnhancePath(path4, "image");
   launcher::EnhancePath(path5, "image");
   launcher::EnhancePath(path6, random);

   EXPECT_EQ(fixed1, path1);
   EXPECT_EQ(fixed2, path2);
   EXPECT_EQ(fixed3, path3);
   EXPECT_EQ(fixed4, path4);
   EXPECT_EQ(fixed5, path5);
  //  EXPECT_EQ("", launcher::EnhancePath(path6, random));
}

// TEST(ExampleTests, EnhancePath_BadInputs) {
//    string exe = ".exe";
//    string slashes = "\\";
//    string svFile = ".sv";
//    string forwardSlash = "//";
//    string dot = ".";
//    string threeChars = "xxx";
//    string fiveChars = "xxxxx";

//   //  EXPECT_EQ("", launcher::EnhancePath(fiveChars, exe));
//   //  EXPECT_EQ("", launcher::EnhancePath(slashes, ""));
//   //  EXPECT_EQ("", launcher::EnhancePath(svFile, svFile));
//   //  EXPECT_EQ("", launcher::EnhancePath(forwardSlash, fiveChars));
//   //  EXPECT_EQ("", launcher::EnhancePath(dot, threeChars));
//   //  EXPECT_EQ("", launcher::EnhancePath(threeChars, dot));
// }

// "C:\Windows\System32\notepad.exe"
// TEST(ExampleTests, checkpath) {
//    string dir = "C:\\Windows\\System32\\notepad.exe";
//    string wrongdir = "C:\Windows\System32\notepad.exe";
//    string random = "\\random.exe";

//    EXPECT_EQ(TRUE, launcer::checkPath(dir));
//    EXPECT_EQ(FALSE, launcer::checkPath(wrongdir));
//    EXPECT_EQ(FALSE, launcer::checkPath(random));
// }


// TEST(ExampleTests, LaunchGame) {
//    string dir = "C:\\Windows\\System32\\notepad.exe";
//    string wrongdir = "C:\Windows\System32\notepad.exe";
//    string random = "\\random.exe";

//    EXPECT_EQ(TRUE, launcer::checkPath(dir));
//    EXPECT_EQ(FALSE, launcer::checkPath(wrongdir));
//    EXPECT_EQ(FALSE, launcer::checkPath(random));
// }



// // MORE TESTS - ASA?

// TEST(ExampleTests, AddGame) {

// }

// TEST(ExampleTests, PlayGame) {

// }

// TEST(ExampleTests, DeleteGame) {

// }

// TEST(ExampleTests, GameList) {

// }

// TEST(ExampleTests, GetData) {

// }

// TEST(ExampleTests, HasPath) {

// }





// Reference Video: https://www.youtube.com/watch?v=Lp1ifh9TuFI


// LEO -
// Logic for enhancepath??
// How to test Launch Game?? -- TRUE? FALSE?
// Escape characters for checkpath



// // Don't need this
// struct ExampleTests
//    : public ::testing:ExampleTests

// {
//    int x;

//    int GetX() {
//       return x;
//    }
//    virtual void SetUp() override {
//       x = 42;
//    }

//    virtual void TearDown() override {
//       delete x;
//    }
// };

// //EXAMPLE
// // To use struct you just say TEST_F
// TEST(ExampleTests, DemonstrateGTestMacros) {
//    EXPECT_TRUE(true); //Expected
//    ASSERT_TRUE(true); // Will not run past this line
//    EXPECT_EQ(true, true);
// }

   // EXPECT_TRUE(true); //Expected
   // ASSERT_TRUE(true); // Will not run past this line
   // EXPECT_EQ(true, true);
   // EXPECT_EQ EnhancePath(string& path, string file_type)