# Weekly status reports (Week 3)
#
## Team Report
### Backend:
Successfully able to get apps to launch using C++.

High Level Goal: Anticipating and handling user errors. Begin setting up a larger system to function with the database and front end.

### Frontend:
Created a simple window that contains a row for a game, containing an image-holder, text-holder, and a button. On click, the button will indicate the game is running.

High Level Goal: Application is able to handle user interaction, and perform changes when trying to add a new game

### Database:
Decided agaomst using a pre-built database API becuase they all use SQL which would overcomplicate things. Approach taken will be a simple text file databse, which will be easier to use, and can be taylored directly to the app's needs.

High Level Goal: Initial database is working (can store games and platforms as structs/objects in the database, and has a list of game and platform names).

### Agenda for Project Meeting:
- Discuss current porgress
- Discuss individual contribution
- Discuss about issues
- Discuss goal for next week

## Contributions
### Leo & Kelby
Last week's goal: N/A.

Progress:
- created a c++ script which uses CreateProcess()
- we were able to launch app through c++

Issue:
- some issues that we solved was figuring out how to deal with paths have spaces
- at first we were going to use System to launch the apps but we learned that
it was resource heavy, defeats security and that your program could get flagged as a virus.
Therfore we used CreateProcess().

Goal for next week:
- By April 19 we should be Anticipating and handling user errors.
Begin setting up a larger system to function with the database and front end.

### Asa
Last week's goal: N/A.

Progress:
- Created git repo.
- Decided on route to take for implementing database.
- Started playing aroun with txt file databases/reading writing to files in c++.

Issues:
- Going to have to figure out how best to store data/not much experience with this.

Goal for next week:
- Keep up with the deadlines.
- Get initial txt file database up and running so that it can store info.

### Steven
Last week's goal: N/A.

Progress: 
- Was into creating a windows application using C# through Visual Studio. Created a simple application for Games In One, which consists of title, add game button, and a row for game information.


Issue:
- was figuring out how to populate multiple rows of game info. Currently, testing it out with creating a class, that contains the components of each row. Each time we add a new game, it will create that class and put those components into a new row.

Goal for next week: 
- Continue to work on handling user interactions for the front end. Look into how to communicate between C++ and C# code. COmplete by April 19.
