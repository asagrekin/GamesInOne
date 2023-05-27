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

## Adding Code
***Steven this part is for you to do***

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
