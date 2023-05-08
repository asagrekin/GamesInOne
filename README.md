# GamesInOne
GamesInOne is a videogame catalog that keeps all of a person’s games in one place. Users can launch their games via the click of a button, even if they belong to different digital gaming platforms, all from one centralized and easy-to-use location. All that is needed is to enter the login to all their different digital platforms and enter the games desired to be cataloged (and their address on the computer). The app aims to mitigate the struggle of trying to find games on different platforms and improve ease of use for gamers so that everything is all in one place.
## Dowloading, Installing, and Running
### Download GamesInOne
To download the current version of the app, simply clone the repo git repo into the desired directory. (Must be on a Windows Computer in order for the app to work).
### Installing GamesInOne
To Install, clone the git repo and run the following command from the root directory:\
`msbuild /m /p:Configuration=Release ./src/front-end/front-end-interface/GamesInOne.sln`
### Running GamesInOne
For now, in order to run the app, run the created GamesInOne.exe in:\
`./src/front-end/front-end/interface/bin/Release/GamesInOne.exe`\
In order to use the app, instructions are provided once the app is started.
### Operational Use Cases
The app allows for adding, deleting, and running games via the click of a button. This can be tested using any executable on your computer, it doesn't actually have to be games (essentially, the app will recognize any executable, even if it isn't a game).
- Add a game (simply click the `Add Game` button, in the top right hand corner).
- Remove a game (click the `Delete` button on the right side of the screen, for the desired app).
- Launch a game (click the `Play` button on the right side of the screen, for the desired app).
## Layout
- Artifacts, members, roles and links are in the ORG file at the top level.
- Weekly reports are located in the reports directory.
  - The report for week X is named WeekXReport.
- Functional code is located in the src directory.
- Issues list located here: https://github.com/users/asagrekin/projects/3
