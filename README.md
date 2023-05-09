# GamesInOne
GamesInOne is a videogame catalog that keeps all of a person’s games in one place. Users can launch their games via the click of a button, even if they belong to different digital gaming platforms, all from one centralized and easy-to-use location. All that is needed is to enter the login to all their different digital platforms and enter the games desired to be cataloged (and their address on the computer). The app aims to mitigate the struggle of trying to find games on different platforms and improve ease of use for gamers so that everything is all in one place.
## Dowloading, Installing, and Running
### Installing MSBuild and .NET
In order to build the app and run it, you will need MSBuild and the .NET framework.
#### Installing MSBuild
MSBuild is included when downloading Visual Studio. If you do not have Visual Studio, you can download it here: [https://code.visualstudio.com/download](https://visualstudio.microsoft.com/vs/)\
\
WHEN INSTALLING, MAKE SURE THAT THE `Desktop development With C++` BOX AND THE `.NET desktop development` BOX ARE BOTH CHECKED. (This contains MSBuild, and .NET build tools).\
\
If Visual Studio is already installed on your device, and you do not have MSBuild, you can get it by opening the Visual Studio installer, and clicking `Modify` by the 2022 community edition, and checking the `Desktop development With C++` and `.NET desktop development` boxes before clicking `Modify` again.
#### Installing .NET
You will need .NET 4.7.2 or later to run the app. To Download: https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472 \
When prompted to chose the version, pick runtime.
### Download GamesInOne
To download the current version of the app, simply clone the repo git repo into the desired directory. (Must be on a Windows Computer in order for the app to work). Run:\
`git clone https://github.com/asagrekin/GamesInOne.git`
### Installing GamesInOne
To compile, clone the git repo and run the following four commands from the repo's root directory (Yes, you need the `$` too!):\
`$env:PATH += ";C:\Program Files\dotnet"`\
`dotnet restore ./src/front-end/front-end-interface/GamesInOne.sln`\
`$env:PATH += ";C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\"`\
`msbuild ./src/front-end/front-end-interface/GamesInOne.sln`
### Running GamesInOne
For now, in order to run the app, run the following command from the git repo's root directory:\
`Start "Games In One App.exe"`
### Operational Use Cases
The app allows for adding, deleting, and running games via the click of a button. This can be tested using any executable on your computer, it doesn't actually have to be games (essentially, the app will recognize any executable, even if it isn't a game).
- Add a game (simply click the `Add Game` button, in the top right hand corner).
  - All fields in the add game screen must be filled to add a game.
- Remove a game (click the `Delete` button on the right side of the screen, for the desired app).
- Launch a game (click the `Play` button on the right side of the screen, for the desired app).
## Layout
- Artifacts, members, roles and links are in the ORG file at the top level.
- Weekly reports are located in the reports directory.
  - The report for week X is named WeekXReport.
- Functional code is located in the src directory.
- Issues list located here: https://github.com/users/asagrekin/projects/3
