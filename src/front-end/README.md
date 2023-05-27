# Overview
This is the implementation of the front-end for the GamesInOne app.

## layout
- front-end-interface
  - Contains the GUI code for the app, in C#
- front-end-test
  - Contains the testing files for the front-end
  - CI config settings are located in: `.github/workflows/main.yml`, under the "Front-End-Test" job
- link-front-and-back
  - Contains the code linking the C# GUI to the C++ backend

## Running the Code
To run the front-end, complete the following steps:
- Download Visual Studio IDE https://visualstudio.microsoft.com/vs/
- WHEN INSTALLING, MAKE SURE THAT THE Desktop `development With C++` BOX AND THE `.NET desktop development` BOX ARE BOTH CHECKED. (This contains MSBuild, and .NET build tools).
- If you already of Visual Studio installed, in the Visual Studio installer, click `Modify` by the 2022 community edition, and checking the `Desktop development With C++` and `.NET desktop development` boxes before clicking Modify again.
- Open up the solution file located at `/src/front-end/front-end-interface/GamesInOne.sln` using Visual Studio IDE.
- Right click the solution and hit `Build` to build the solution, and click `Start` at the top of the IDE to start the app for debugging.

## Adding Code
***Steven this part is for you to do. Input format requiremnets, etc.***

## Linking Code Between the Front and Back Ends
The interface between the front and back ends is located in the `link-front-and-back` directory. The method calls that link the two are coded in C++.\
The source code for the method calls is located in `LinkFrontAndBack.cpp`.\
The documentation for the method calls is located in `LinkFrontAndBack.h`.

## Adding Tests
The front-end testing uses the MSTest framework. Documentation [here](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest).\
The location of the testing file is: `src/front-end/front-end-test/FrontEndUnitTest.cs`.\
Tests should be added in the following format:
```
[TestMethod]
public void <TestMethodName>()
{
  <Contents of test>
}
```
