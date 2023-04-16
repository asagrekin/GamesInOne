# Weekly status reports (Week 4)
#
## Team Report
### Backend:
Created a system to handle poor user inputs as well as a strong foundation to begin connecting to database and frontend.

High Level Goal: Begin to have a functioning interaction with the database. Storing, deleting, and retrieving games that are within the database.

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
Last week's goal: 
- By April 19 we should be Anticipating and handling user errors.
Begin setting up a larger system to function with the database and front end.

Progress:
- Created two new methods to handle poor user inputs. The method called checkPath checks to make sure the inputted path is a valid path to execute. The method EnhancePath checks that the file is of type .exe and if it is it fixes the path to account for needed escape characters. Additionally, we created a way to take in user input and store it which accompilshes our goal of setting up a larger system to function with database and front end.

Issue:
- Ran into some varaible type issues when factoring code out of main into seperate methods. Simple fix was being more cautious when using string and making sure to use addresses of the strings' starts when referencing.

Goal for next week:
- By April 26 we plan to have a functioning interaction with the database. Storing, deleting, and retrieving games that are within the database.

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
